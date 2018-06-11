using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ava.caronas.api.Dominio;
using ava.caronas.api.Repositorio;

namespace ava.caronas.api.test
{
    [TestClass]
    public class RepositorioColaboradorTest
    {
        [TestMethod] //verificar se colaborador foi adicionado
        public void AddColaborador()
        {
            //preparação 
            var colaborador = new Colaborador("Marina", "marina.resende.lira", 1111);
            var repositorio = new RepositorioColaborador();
            //execução
            repositorio.AddColaborador(colaborador);
            //verificacao
            var tamanho = 1;//valor esperado para o tamanho da lista

            Assert.AreEqual(tamanho, repositorio.Colaboradores.Count);


        }

        [TestMethod]
        public void IdentificaPIDColaborador()
        {
            var valor_esperado = 1112;
            var repositorio = new RepositorioColaborador();
            for (int i = 0; i < 6; i++)
            {
                var colaborador = new Colaborador($"Marina {i}", "marina.resende.lira" + i, 1111 + i);
                repositorio.AddColaborador(colaborador);
            }
            Assert.AreEqual(valor_esperado, repositorio.ObterPID(valor_esperado).PID);
        }

        [TestMethod]
        public void IdentificaPIDColaboradorNulo()
        {
            var valor_esperado = 837289347;
            var repositorio = new RepositorioColaborador();
            //repositorio.FindPID(valor_esperado, repositorio.TamanhodaLista());
            for (int i = 0; i < 6; i++)
            {
                var colaborador = new Colaborador($"Marina {i}", "marina.resende.lira" + i, 1111 + i);
                repositorio.AddColaborador(colaborador);
            }
            Assert.IsNull(repositorio.ObterPID(valor_esperado));
        }

        [TestMethod]
        public void GetById_EncontraCaronaCorreta()
        {
            var repositorio = new RepositorioCarona();
            for (int i = 0; i < 6; i++)
            {
                var carona = Carona.CreateCarona(2, new Colaborador($"Marina { i }", "marina.resende.lira" + i, 1111 + i));
                repositorio.AddCarona(carona);
            }
            var achar_carona_certa = repositorio.GetByID(2);
            Assert.AreEqual(achar_carona_certa, repositorio.Caronas[1]);

        }

    }
}

