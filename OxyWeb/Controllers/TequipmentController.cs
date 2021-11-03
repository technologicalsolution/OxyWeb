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
    public class TequipmentController : Controller
    {
        private readonly ModelOxy _context;

        public TequipmentController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("equipment")]
        public IActionResult Index()
        {
            ViewEquipment Model = new ViewEquipment();
            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Model.Accion = (int)DbAcciones.create;

                List<VEquipment> ListEquipment = new List<VEquipment>();
                if (idRol == (int)UserRol.Root)
                {
                    ListEquipment = (from A in _context.Tvendors
                                     join B in _context.TEquipments on A.Id equals B.VendorID                                     
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
                }
                else
                {
                    ListEquipment = (from A in _context.Tvendors
                                     join B in _context.TEquipments on A.Id equals B.VendorID
                                     where B.idRol == idRol
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
                }

                Model.Lista = ListEquipment;
                Model.Accion = (int)DbAcciones.create;
                Model.Modelo = new TEquipment
                {
                    idRol = (int)idRol
                };

            }
            return View(Model);
        }

        [HttpPost]
        public JsonResult Crud(ViewEquipment data)
        {
            if (ModelState.IsValid)
            {
                string message = "Se creo correctamente";
                if (data.Accion == (int)DbAcciones.create)
                {
                    _context.TEquipments.Add(data.Modelo);
                    _context.SaveChanges();
                }
                else if (data.Accion == (int)DbAcciones.update)
                {
                    message = "fue modificado correctamente";
                    TEquipment Actualizar = _context.TEquipments.Where(l => l.id == data.Modelo.id).FirstOrDefault();

                    Actualizar.id = data.Modelo.id;
                    Actualizar.EqpPrice = data.Modelo.EqpPrice;
                    Actualizar.EqpTagDate = data.Modelo.EqpTagDate;
                    Actualizar.EquipmentDescription = data.Modelo.EquipmentDescription;
                    Actualizar.EquipmentTag = data.Modelo.EquipmentTag;
                    Actualizar.EquipmentType = data.Modelo.EquipmentType;
                    Actualizar.PartNumber = data.Modelo.PartNumber;
                    Actualizar.SerialNumber = data.Modelo.SerialNumber;
                    Actualizar.VendorID = data.Modelo.VendorID;

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
            TEquipment Eliminar = _context.TEquipments.Where(l => l.id == Id).FirstOrDefault();

            if (Eliminar != null)
            {
                _context.TEquipments.Remove(Eliminar);
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
