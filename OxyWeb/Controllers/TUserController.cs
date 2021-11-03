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
    public class TUserController : Controller
    {
        private readonly ModelOxy _context;

        public TUserController(ModelOxy contexto)
        {
            _context = contexto;
        }

        [Route("user")]
        public IActionResult Index()
        {
            ViewUser Model = new ViewUser();
            int? idRol = HttpContext.Session.GetInt32("IdRol");

            if (idRol == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<VUser> ListUser = new List<VUser>();
                if (idRol == (int)UserRol.Root)
                {
                    ListUser = (from A in _context.TUsers
                                where A.idRol != (int)UserRol.Root
                                select new VUser
                                {
                                    Id = A.Id,
                                    active = A.active,
                                    idRol = A.idRol,
                                    nameRol = ((UserRol)A.idRol).ToString(),
                                    lastName = A.lastName,
                                    name = A.name,
                                    pass = A.pass,
                                    user = A.user
                                }).ToList();
                }
                else
                {
                    ListUser = (from A in _context.TUsers
                                where A.idRol == idRol
                                select new VUser
                                {
                                    Id = A.Id,
                                    active = A.active,
                                    idRol = A.idRol,
                                    nameRol = ((UserRol)A.idRol).ToString(),
                                    lastName = A.lastName,
                                    name = A.name,
                                    pass = A.pass,
                                    user = A.user
                                }).ToList();
                }

                Model.Lista = ListUser;
                Model.Accion = (int)DbAcciones.create;
                Model.Modelo = new TUser
                {
                    idRol = (int)idRol
                };

            }
            return View(Model);
        }

        [HttpPost]
        public JsonResult Crud(ViewUser data)
        {
            if (ModelState.IsValid)
            {
                string message = "Se creo correctamente";
                if (data.Accion == (int)DbAcciones.create)
                {
                    _context.TUsers.Add(data.Modelo);
                    _context.SaveChanges();
                }
                else if (data.Accion == (int)DbAcciones.update)
                {
                    message = "fue modificado correctamente";
                    TUser Actualizar = _context.TUsers.Where(l => l.Id == data.Modelo.Id).FirstOrDefault();

                    Actualizar.Id = data.Modelo.Id;
                    Actualizar.active = data.Modelo.active;
                    Actualizar.idRol = data.Modelo.idRol;
                    Actualizar.lastName = data.Modelo.lastName;
                    Actualizar.name = data.Modelo.name;
                    Actualizar.pass = data.Modelo.pass;
                    Actualizar.user = data.Modelo.user;

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
            TUser Eliminar = _context.TUsers.Where(l => l.Id == Id).FirstOrDefault();

            if (Eliminar != null)
            {
                _context.TUsers.Remove(Eliminar);
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
