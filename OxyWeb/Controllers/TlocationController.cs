using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OxyWeb.Enums;
using OxyWeb.Models;
using OxyWeb.ViewModels;
using System;
using System.Linq;

namespace OxyWeb.Controllers
{
    public class TlocationController : Controller
    {
        private readonly ModelOxy _context;

        public TlocationController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("location")]
        public IActionResult Index()
        {
            ViewLocation Model = new ViewLocation();

            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (idRol == (int)UserRol.Root)
                {
                    Model.Lista = _context.TLocations.ToList();
                }
                else
                {
                    Model.Lista = _context.TLocations.Where(t => t.idRol == idRol).ToList();
                }
                
                Model.Accion = (int)DbAcciones.create;
                Model.Modelo = new TLocation
                {
                    idRol = (int)idRol
                };
            }
            return View(Model);
        }

        [HttpPost]
        public JsonResult Crud(ViewLocation data)
        {
            if (ModelState.IsValid)
            {
                string message = "Se creo correctamente";
                if (data.Accion == (int)DbAcciones.create)
                {
                    _context.TLocations.Add(data.Modelo);
                    _context.SaveChanges();
                }
                else if (data.Accion == (int)DbAcciones.update)
                {
                    message = "fue modificado correctamente";
                    TLocation Actualizar = _context.TLocations.Where(l => l.Id == data.Modelo.Id).FirstOrDefault();

                    Actualizar.location = data.Modelo.location;                    

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
            TLocation Eliminar = _context.TLocations.Where(l => l.Id == Id).FirstOrDefault();

            if (Eliminar != null)
            {
                _context.TLocations.Remove(Eliminar);
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
