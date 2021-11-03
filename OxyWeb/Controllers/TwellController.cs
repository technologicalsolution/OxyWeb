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
    public class TwellController : Controller
    {
        private readonly ModelOxy _context;

        public TwellController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("well")]
        public IActionResult Index()
        {
            ViewWell Model = new ViewWell();
            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<VWell> ListWells = new List<VWell>();
                if (idRol == (int)UserRol.Root)
                {
                    ListWells = (from A in _context.TWells
                                 join B in _context.Tfields on A.FieldId equals B.Id                                 
                                 select new VWell
                                 {
                                     Id = A.Id,
                                     FieldId = A.FieldId,
                                     Name = A.Name.Trim(),
                                     TfieldName = B.Name.Trim()
                                 }).ToList();
                }
                else
                {
                    ListWells = (from A in _context.TWells
                                  join B in _context.Tfields on A.FieldId equals B.Id
                                  where A.idRol == idRol
                                  select new VWell
                                  {
                                      Id = A.Id,
                                      FieldId = A.FieldId,
                                      Name = A.Name.Trim(),
                                      TfieldName = B.Name.Trim()
                                  }).ToList();
                }

                Model.Lista = ListWells;
                Model.Accion = (int)DbAcciones.create;
                Model.Modelo = new TWell
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