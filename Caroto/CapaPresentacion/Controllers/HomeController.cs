﻿using Caroto.Models;
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
        public ActionResult Index(Principal loginDataModel)
        {
            Principal bdusu = new Principal();
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
            return View(new Principal());
        }

        [HttpPost]
        public ActionResult Registro(Principal loginDataModel)
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
        public ActionResult MenuGammasCoche(GammaViewModel gamma)
        {
            Principal princ = new Principal();
            if (ModelState.IsValid)
            {
                CN_Vehiculo veh = new CN_Vehiculo();
                DataTable table = veh.MostrarVeh();
                veh.MostrarVeh();
                if (table.Rows.Count > 0)
                {
                    DataRow linea = table.Rows[0];
                    princ.Correo = linea.Field<string>(0);
                    princ.Contraseña = linea.Field<string>(1);
                }

                return RedirectToAction("MenuGammasCoche");
            }
            else
            {
                return View(gamma);
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