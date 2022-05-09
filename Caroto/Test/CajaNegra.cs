using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Caroto.Models;
using System;
using CapaPresentacion.Controllers;

namespace Test
{
    [TestClass]
    public class CajaNegra
    {
        [TestMethod]
        public void Prueba1()
        {
            var controller = new CarotoController();
            var result = controller.VistaPrueba() as ViewResult;

            Assert.AreEqual("Prueba", result.ViewName);
        }
    }
}
