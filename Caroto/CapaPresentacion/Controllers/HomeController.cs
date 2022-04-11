using Caroto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
using System.Data;
using MySql.Data.MySqlClient;

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
                CN_Usuarios u = new CN_Usuarios(); 
                u.MostrarUsu();

                return RedirectToAction("MenuSeleccionVehiculo");
            }
            else
            {
                return View(loginDataModel);
            }
        }

        

        public ActionResult Registro()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Registro(LoginViewModel loginDataModel)
        {
            if (ModelState.IsValid)
            {
                CN_Usuarios u = new CN_Usuarios();
                u.MostrarUsu();
                u.InsertarUsu(loginDataModel.Correo, loginDataModel.Contraseña);

                return RedirectToAction("MenuSeleccionVehiculo");
            }
            else
            {
                return View(loginDataModel);
            }
        }

        public ActionResult MenuSeleccionVehiculo()
        {
            return View();
        }

        
    }
}