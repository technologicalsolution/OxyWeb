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
using System.Threading.Tasks;

namespace OxyWeb.Controllers
{
    public class TfieldController : Controller
    {
        private readonly ModelOxy _context;

        public TfieldController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("field")]
        public IActionResult Index()
        {
            ViewField Model = new ViewField();
            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {

                List<Tfield> ListVendor = new List<Tfield>();
                if (idRol == (int)UserRol.Root)
                {
                    ListVendor = (from A in _context.Tfields                                  
                                  select new Tfield
                                  {
                                      Id = A.Id,
                                      Name = A.Name.Trim(),
                                  }).ToList();
                }
                else
                {
                    ListVendor = (from A in _context.Tfields
                                  where A.idRol == idRol
                                  select new Tfield
                                  {
                                      Id = A.Id,
                                      Name = A.Name.Trim(),
                                  }).ToList();
                }

                Model.Lista = ListVendor;
                Model.Accion = (int)DbAcciones.create;
                Model.Modelo = new Tfield
                {
                    idRol = (int)idRol
                };

            }
            return View(Model);
        }

        [HttpPost]
        public JsonResult Crud(ViewField data)
        {
            if (ModelState.IsValid)
            {
                string message = "Se creo correctamente";
                if (data.Accion == (int)DbAcciones.create)
                {
                    _context.Tfields.Add(data.Modelo);
                    _context.SaveChanges();
                }
                else if (data.Accion == (int)DbAcciones.update)
                {
                    message = "fue modificado correctamente";
                    Tfield Actualizar = _context.Tfields.Where(l => l.Id == data.Modelo.Id).FirstOrDefault();

                    Actualizar.Name = data.Modelo.Name;

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

        [HttpGet]
        public JsonResult GetItems(int FielID)
        {
            List<TWell> TWells = (from B in _context.TWells
                                  where B.FieldId == FielID
                                  select B).ToList();

            return Json(JsonConvert.SerializeObject(TWells));
        }


        [HttpDelete]
        public JsonResult Crud(int Id)
        {
            Tfield Eliminar = _context.Tfields.Where(l => l.Id == Id).FirstOrDefault();

            if (Eliminar != null)
            {
                List<TWell> wells = _context.TWells.Where(e => e.FieldId == Eliminar.Id).ToList();

                if (wells.Count() > 0)
                {
                    _context.TWells.RemoveRange(wells);
                    _context.SaveChanges();
                }

                _context.Tfields.Remove(Eliminar);
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
