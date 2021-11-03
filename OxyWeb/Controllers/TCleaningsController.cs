using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OxyWeb.Enums;
using OxyWeb.Models;
using OxyWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OxyWeb.Controllers
{
    public class TCleaningsController : Controller
    {
        private readonly ModelOxy _context;

        public TCleaningsController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("cleaning")]
        public IActionResult Index()
        {
            ViewCleaning Model = new ViewCleaning();
            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Model.Accion = (int)DbAcciones.create;
                if (idRol == (int)UserRol.Root)
                {
                    Model.Lista = _context.TCleanings.ToList();
                }
                else
                {
                    Model.Lista = _context.TCleanings.Where(t => t.idRol == (int)idRol).ToList();
                }
                
                Model.Modelo = new TCleaning
                {
                    idRol = (int)idRol
                };
            }
            return View(Model);
        }

        [HttpPost]
        public JsonResult Crud(ViewCleaning data)
        {
            if (ModelState.IsValid)
            {
                string message = "Se creo correctamente";
                if (data.Accion == (int)DbAcciones.create)
                {
                    _context.TCleanings.Add(data.Modelo);
                    _context.SaveChanges();
                }
                else if (data.Accion == (int)DbAcciones.update)
                {
                    message = "fue modificado correctamente";
                    TCleaning Actualizar = _context.TCleanings.Where(l => l.Id == data.Modelo.Id).FirstOrDefault();

                    Actualizar.name = data.Modelo.name;

                    _context.Entry(Actualizar).State = EntityState.Modified;
                    _context.SaveChanges();
                }

                return Json(JsonConvert.SerializeObject(new VResponse { Number = 200, Message = message }));
            }
            else
            {
                var Errores = ModelState.Values.ToList();
                return Json(JsonConvert.SerializeObject(new VResponse { Number = 101, Message = string.Join(Environment.NewLine, Errores.Where(e => e.Errors.Count() > 0).Select(s => string.Format("Error : {0}", string.Join(",", s.Errors.Select(s => s.ErrorMessage).ToList())))) }));
            }
        }


        [HttpDelete]
        public JsonResult Crud(int Id)
        {
            TCleaning Eliminar = _context.TCleanings.Where(l => l.Id == Id).FirstOrDefault();

            if (Eliminar != null)
            {                
                _context.TCleanings.Remove(Eliminar);
                _context.SaveChanges();

                return Json(JsonConvert.SerializeObject(new VResponse { Number = 200, Message = "fue eliminado correctamente" }));
            }
            else
            {
                return Json(JsonConvert.SerializeObject(new VResponse { Number = 101, Message = "No fue eliminado" }));
            }
        }
    }
}

