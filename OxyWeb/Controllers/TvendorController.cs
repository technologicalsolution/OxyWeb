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
    public class TvendorController : Controller
    {
        private readonly ModelOxy _context;

        public TvendorController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("vendor")]
        public IActionResult Index()
        {
            ViewVendor Model = new ViewVendor();
            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<Tvendor> ListVendor = new List<Tvendor>();
                if (idRol == (int)UserRol.Root)
                {
                    ListVendor = (from A in _context.Tvendors
                                  select new Tvendor
                                  {
                                      Id = A.Id,
                                      Name = A.Name.Trim()
                                  }).ToList();
                }
                else
                {
                    ListVendor = (from A in _context.Tvendors
                                  where A.idRol == idRol
                                  select new Tvendor
                                  {
                                      Id = A.Id,
                                      Name = A.Name.Trim()
                                  }).ToList();
                }

                Model.Lista = ListVendor;
                Model.Accion = (int)DbAcciones.create;
                Model.Modelo = new Tvendor
                {
                    idRol = (int)idRol
                };

            }
            return View(Model);
        }

        [HttpPost]
        public JsonResult Crud(ViewVendor data)
        {
            if (ModelState.IsValid)
            {
                string message = "Se creo correctamente";
                if (data.Accion == (int)DbAcciones.create)
                {
                    _context.Tvendors.Add(data.Modelo);
                    _context.SaveChanges();
                }
                else if (data.Accion == (int)DbAcciones.update)
                {
                    message = "fue modificado correctamente";
                    Tvendor Actualizar = _context.Tvendors.Where(l => l.Id == data.Modelo.Id).FirstOrDefault();

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
        public JsonResult GetItems(int VendorID)
        {
            List<VEquipment> TEquipments = (from B in _context.TEquipments
                                            join A in _context.Tvendors on B.VendorID equals A.Id
                                            where B.VendorID == VendorID
                                            select new VEquipment
                                            {
                                                EqpPrice = B.EqpPrice,
                                                EqpTagDate = B.EqpTagDate,
                                                EquipmentDescription = B.EquipmentDescription.Trim(),
                                                EquipmentTag = B.EquipmentTag.Trim(),
                                                EquipmentType = B.EquipmentType.Trim(),
                                                id = B.id,
                                                PartNumber = B.PartNumber.Trim(),
                                                SerialNumber = B.SerialNumber.Trim(),
                                                VendorID = B.VendorID,
                                                TvendorName = A.Name.Trim()
                                            }).ToList();

            return Json(JsonConvert.SerializeObject(TEquipments));
        }

        [HttpDelete]
        public JsonResult Crud(int Id)
        {
            Tvendor Eliminar = _context.Tvendors.Where(l => l.Id == Id).FirstOrDefault();

            if (Eliminar != null)
            {
                List<TEquipment> equipments = _context.TEquipments.Where(e => e.VendorID == Eliminar.Id).ToList();

                if (equipments.Count() > 0)
                {
                    _context.TEquipments.RemoveRange(equipments);
                    _context.SaveChanges();
                }

                _context.Tvendors.Remove(Eliminar);
                _context.SaveChanges();

                return Json(JsonConvert.SerializeObject(new VResponse { Number = 200, Message = "fue eliminado correctamente" }));
            }
            else
            {
                return Json(JsonConvert.SerializeObject(new VResponse { Number = 101, Message = "No fue eliminado" }));
            }
        }

        [Route("AllVendor/{idRol}")]
        [HttpGet]
        public JsonResult GetVendor(int idRol)
        {
            var ListVendor = (from A in _context.Tvendors
                              where A.idRol == idRol
                              select new Tvendor
                              {
                                  Id = A.Id,
                                  Name = A.Name.Trim()
                              }).ToList();

            return Json(JsonConvert.SerializeObject(ListVendor));
        }
    }

}