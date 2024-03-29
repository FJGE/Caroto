﻿using CapaNegocio;
using CapaSoporte;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaPresentacion.Controllers
{
    public class CarotoController : Controller
    {
        public ActionResult Index()
        {
            Principal prin = new Principal();

            prin.Titulo = "Caroto";
            prin.Descripcion = "Tienda Web para comprar y personalizar el Vehiculo que quieras";
            prin.Iniciar_Sesion = "Iniciar Sesión";
            prin.Productos = "Productos";
            prin.Sobre_Nosotros = "Sobre Nosotros";
            prin.Descripcion2 = "Somos una tienda web dedicada a la venta de vehiculos personalizados por los usuarios para que puedan comprar el coche de sus sueños.<br /><br />Elige tu Coche o Moto disponible entre una serie de gamas.<br /><br /> Añadele las piezas para hacer de tu vehiculo una experiencia unica";


            Gama sec1 = new Gama();
            Gama sec2 = new Gama();

            sec1.Titulo = "Coches";
            sec1.Descripcion = "Elige un coche y personalizalo con las piezas disponibles de tu agrado.";

            sec2.Titulo = "Motos";
            sec2.Descripcion = "Elige un moto personalizala y presume de ella ante tus amigos.";

            prin.secun = new List<Gama>();
            prin.secun.Add(sec1);
            prin.secun.Add(sec2);


            return View(prin);
        }

        [HttpPost]
        public ActionResult Index(Principal loginDataModel)
        {
            Principal bdusu = new Principal();

            if (ModelState.IsValid)
            {
                try
                {
                    CN_Usuarios usu = new CN_Usuarios();
                    DataTable compUsu = usu.ComprobarUsu(loginDataModel.Correo, loginDataModel.Contraseña);
                    usu.ComprobarUsu(loginDataModel.Correo, loginDataModel.Contraseña);
                    if (compUsu.Rows.Count > 0)
                    {
                        DataRow linea = compUsu.Rows[0];
                        bdusu.Correo = linea.Field<string>(0);
                        bdusu.Contraseña = linea.Field<string>(1);
                    }

                    if (loginDataModel.Correo == bdusu.Correo && loginDataModel.Contraseña == bdusu.Contraseña)
                    {
                        return RedirectToAction("SeleccionVehiculo");
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
            Principal prin = new Principal();

            prin.Titulo = "Crea tu cuenta";
            return View(prin);
        }

        [HttpPost]
        public ActionResult Registro(Principal loginDataModel)
        {
            if (ModelState.IsValid)
            {
                CN_Usuarios usu = new CN_Usuarios();
                usu.InsertarUsu(loginDataModel.Correo, loginDataModel.Contraseña);

                return RedirectToAction("SeleccionVehiculo");
            }
            else
            {
                return View(loginDataModel);
            }
        }

        public ActionResult SeleccionVehiculo()
        {
            Principal prin = new Principal();
            Gama sec1 = new Gama();
            Gama sec2 = new Gama();

            sec1.Titulo = "Coche";
            sec1.Descripcion = "GamasCoches";

            sec2.Titulo = "Moto";
            sec2.Descripcion = "GamasMotos";


            prin.secun = new List<Gama>();
            prin.secun.Add(sec1);
            prin.secun.Add(sec2);

            return View(prin);
        }

        public ActionResult GamasCoches()
        {
            CN_Coche car = new CN_Coche();
            DataSet carTable = car.MostrarProd();
            AllList lista1 = new AllList();

            lista1.CochesBajos = listadecoches(carTable.Tables[2]);
            lista1.CochesMedios = listadecoches(carTable.Tables[1]);
            lista1.CochesAltos = listadecoches(carTable.Tables[0]);

            return View(lista1);
        }

        public ActionResult GamasMotos()
        {
            CN_Moto motorbike = new CN_Moto();
            DataSet bikeTable = motorbike.MostrarProd();
            AllList lista2 = new AllList();

            lista2.MotosBajas = listademotos(bikeTable.Tables[0]);
            lista2.MotosMedias = listademotos(bikeTable.Tables[1]);
            lista2.MotosAltas = listademotos(bikeTable.Tables[2]);

            return View(lista2);
        }

        public ActionResult PiezasCoche(string matricula, string imagen)
        {
            CN_PiezasCoche piezas = new CN_PiezasCoche();
            DataTable piecesTable = piezas.MostrarProd();
            AllList lista1 = new AllList();

            foreach (DataRow a in piecesTable.Rows)
            {
                Gama pieceView = new Gama();
                pieceView.id = (int)a["Id"];
                pieceView.nombre = (string)a["Nombre"];
                pieceView.Imagen = (string)a["Imagen"];
                pieceView.precio = (decimal)a["precio"];

                lista1.PiezasCoche.Add(pieceView);
            }
            ViewBag.matricula = matricula;
            ViewBag.imagen = imagen;

            return View(lista1);
        }

        public ActionResult PiezasMoto(string matricula,string imagen)
        {
            CN_PiezasMoto piezas = new CN_PiezasMoto();
            DataTable piecesTable = piezas.MostrarProd();
            AllList lista1 = new AllList();

            foreach (DataRow a in piecesTable.Rows)
            {
                Gama pieceView = new Gama();
                pieceView.id = (int)a["Id"];
                pieceView.nombre = (string)a["Nombre"];
                pieceView.Imagen = (string)a["Imagen"];
                pieceView.precio = (decimal)a["precio"];

                lista1.PiezasMoto.Add(pieceView);
            }
            ViewBag.matricula = matricula;
            ViewBag.imagen = imagen;

            return View(lista1);
        }

        public ActionResult Compra(string matricula, string imagen)
        {
            ViewBag.matricula = matricula;
            ViewBag.imagen = imagen;

            return View();
        }

        private List<Gama> listademotos(DataTable bikeTable)
        {
            List<Gama> gm = new List<Gama>();
            foreach (DataRow a in bikeTable.Rows)
            {
                Gama bikeView = new Gama();
                bikeView.matricula = (string)a["Matricula"];
                bikeView.Imagen = (string)a["Imagen"];

                gm.Add(bikeView);
            }
            return gm;
        }

        private List<Gama> listadecoches(DataTable carTable)
        {
            List<Gama> gm = new List<Gama>();
            foreach (DataRow a in carTable.Rows)
            {
                Gama carView = new Gama();
                carView.matricula = (string)a["Matricula"];
                carView.Imagen = (string)a["Imagen"];

                gm.Add(carView);
            }
            return gm;
        }

        public ActionResult VistaPrueba()
        {

            return View("Prueba");
        }
    }
}
