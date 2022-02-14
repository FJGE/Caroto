using Caroto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Caroto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel loginDataModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SegundaPagina");
            }
            else
            {
                return View(loginDataModel);
            }
        }

        public ActionResult SegundaPagina()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }
    }
}