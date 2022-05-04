using Caroto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;
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
            CN_Coche car = new CN_Coche();
            DataTable carTable = car.MostrarProd();
            AllList lista1 = new AllList();

            return View(lista1);
        }

        public ActionResult MenuGammasMoto()
        {
            CN_Moto motorbike = new CN_Moto();
            DataSet bikeTable = motorbike.MostrarProd();
            AllList lista1 = new AllList();
            lista1.MotosBajas = listademotos(bikeTable.Tables[0]);
            lista1.MotosMedias = listademotos(bikeTable.Tables[1]);
            lista1.MotosAltas= listademotos(bikeTable.Tables[2]);

            

            return View(lista1);

            
        }
        private List<GammaViewModel> listademotos(DataTable bikeTable)
        {
            List<GammaViewModel> gm = new List<GammaViewModel>();
            foreach (DataRow a in bikeTable.Rows)
            {
                GammaViewModel bikeView = new GammaViewModel();
                bikeView.matricula = (string)a["Matricula"];

                gm.Add(bikeView);
            }
            return gm;
        }
    }
}