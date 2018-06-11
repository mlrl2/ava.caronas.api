using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ava.caronas.api.Dominio;
using ava.caronas.api.Repositorio;


namespace ava.caronas.api.test
{
    [TestClass]
    public class CaronaRepositorioTest
    {
        [TestMethod]
        public void AddCarona_IncrementaOTamanhoDaListaDeCaronas()
        {
            var repositorio = new RepositorioCarona();
            var carona1 = Carona.CreateCarona(2, new Colaborador("Adam Smith", "a.smith", 1001));
            var carona2 = Carona.CreateCarona(5, new Colaborador("John Doe", "j.doe", 1002));
            repositorio.AddCarona(carona1);
            repositorio.AddCarona(carona2);
            int count = 2;
            Assert.AreEqual(count, repositorio.Caronas.Count);
        }
        [TestMethod]
        public void SetID_AtribuiIDCorreto()
        {
            var repositorio = new RepositorioCarona();
            for (int i = 0; i < 6; i++)
            {
                var carona = Carona.CreateCarona(3, new Colaborador($"Marina {i}", "marina.resende.lira" + i, 1111 + i));
                repositorio.AddCarona(carona);
            }
            repositorio.DeleteCarona(repositorio.Caronas[3]);
            var carona_teste = Carona.CreateCarona(6, new Colaborador("Marina", "marina.resende.lira", 1111));
            repositorio.AddCarona(carona_teste);
            Assert.AreEqual(7, carona_teste.ID);
        }
    }
}