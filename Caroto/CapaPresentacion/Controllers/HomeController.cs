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
            LoginViewModel bdusu = new LoginViewModel();
            if (ModelState.IsValid)
            {
                try
                {
                    CN_Usuarios u = new CN_Usuarios();
                    DataTable busu = u.ComprobarUsu(loginDataModel.Correo, loginDataModel.Contraseña);
                    u.ComprobarUsu(loginDataModel.Correo, loginDataModel.Contraseña);
                    if (busu.Rows.Count > 0)
                    {
                        DataRow linea = busu.Rows[0];
                        bdusu.Correo = linea.Field<string>(0);
                        bdusu.Contraseña = linea.Field<string>(1);
                    }

                    if (loginDataModel.Correo == bdusu.Correo && loginDataModel.Contraseña == bdusu.Contraseña)
                    {
                        return RedirectToAction("MenuSeleccionVehiculo");
                    }
                    else
                    {
                        return RedirectToAction("Registro");
                    }
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    return View(loginDataModel);
                }
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

        public ActionResult MenuGammasCoche()
        {
            return View(new GammaViewModel());
        }

        [HttpPost]
        public ActionResult MenuGammasCoche(GammaViewModel Gamma)
        {
            if (ModelState.IsValid)
            {
                CN_Vehiculo veh = new CN_Vehiculo();
                DataTable table = u.ComprobarUsu(GammaViewModel.Correo, loginDataModel.Contraseña);
                u.ComprobarUsu(loginDataModel.Correo, loginDataModel.Contraseña);
                if (busu.Rows.Count > 0)
                {
                    DataRow linea = busu.Rows[0];
                    bdusu.Correo = linea.Field<string>(0);
                    bdusu.Contraseña = linea.Field<string>(1);
                }

                if (loginDataModel.Correo == bdusu.Correo && loginDataModel.Contraseña == bdusu.Contraseña)
                {
                    return RedirectToAction("MenuGammasCoche");
                }
                else
                {
                    return RedirectToAction("Registro");
                }

                
            }
            else
            {
                return View(Gamma);
            }
        }

        public ActionResult MenuGammasMoto()
        {
            return View(new GammaViewModel());
        }

        [HttpPost]
        public ActionResult MenuGammasMoto(GammaViewModel Gamma)
        {
            if (ModelState.IsValid)
            {
                CN_Gamma u = new CN_Gamma();
                u.MostrarGamma();

                return RedirectToAction("MenuGammasMoto");
            }
            else
            {
                return View(Gamma);
            }
        }
    }
}