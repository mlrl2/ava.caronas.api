using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ava.caronas.api.Dominio;
using ava.caronas.api.Repositorio;
namespace ava.caronas.api.test
{
    [TestClass]
    public class CaronaTest
    {
        [TestMethod]
        public void CreateCarona_NaoPermiteMaisDeSeisVagas()
        {
            var carona = Carona.CreateCarona(7, new Colaborador("mike", "m.ike", 1001));
            Assert.IsNull(carona);
        }

        [TestMethod]
        public void CreateCarona_NaoPermitirCaronaSemOfertante()
        {
            var carona = Carona.CreateCarona(2, null);
            Assert.IsNull(carona);
        }
        
        [TestMethod]
        public void OcuparVaga_FaltaVaga()
        {
            var carona = Carona.CreateCarona(0, new Colaborador("mike", "m.ike", 1001));
            bool ocupado = carona.OcuparVaga();
            //bool ocupado = false;
            Assert.IsFalse(ocupado);
        }
    }
}
