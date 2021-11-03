using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OxyWeb.Enums;
using OxyWeb.Models;
using OxyWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OxyWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelOxy _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ModelOxy contexto)
        {
            _context = contexto;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            VLogin Data = new VLogin();
            return View(Data);
        }

        [HttpPost]
        public IActionResult Index(VLogin Data)
        {
            var UniqueUser = (from A in _context.TUsers
                              where A.user.ToUpper() == Data.user.ToUpper()
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
                              }).FirstOrDefault();

            if (UniqueUser != null)
            {
                if (UniqueUser.pass == Data.pass)
                {                    
                    HttpContext.Session.SetInt32("IdRol", UniqueUser.idRol);

                    return RedirectToRoute("vendor");
                }
                else
                {
                    Data.Error = true;
                    Data.Mensaje = "Password does not match";
                    return View("Index", Data);
                }
            }
            else
            {
                Data.Error = true;
                Data.Mensaje = "Username does not exist";
                return View("Index", Data);
            }
        }

        [Route("LogOut")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
