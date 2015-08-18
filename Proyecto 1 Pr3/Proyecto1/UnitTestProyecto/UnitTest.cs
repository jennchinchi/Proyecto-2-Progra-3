using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaNegocios;
using AccesoDatos;

namespace UnitTestProyecto
{
    [TestClass()]
    public class GestorTests
    {
        private static IAvionDa avionAD = new AvionDaImpl();
        private static ITiqueteDa tiqueteAD = new TiqueteDaImpl();
        private static IVueloDa vueloAD = new VueloDaImpl();
        private static IClienteDa clienteAD = new ClienteDaImpl();
        private static ILugarDa lugarAD = new LugarDaImpl();
        //*unittest
        [TestMethod()]
        public void buscarAvionPorIdTest()
        {
            Avion a = avionAD.buscarAvionPorId(1);
            Assert.AreEqual(a.Marca, "Taca");
        }
        //*unittest
        [TestMethod()]
        public void listarAvionesTest()
        {
            List<Avion> lista = avionAD.listarAviones();
            Assert.AreNotEqual(lista, null);
        }
        //*unittest
        [TestMethod()]
        public void buscarLugarPorIdTest()
        {
            Lugar l = lugarAD.buscarLugarPorId(1);
            Assert.AreEqual(l.Nombre, "San Francisco California, EEUU");
        }
        //*unittest
        [TestMethod()]
        public void listarLugaresTest()
        {
            List<Lugar> lista = lugarAD.listarLugares();
            Assert.AreNotEqual(lista, null);
        }
        //*unittest
        [TestMethod()]
        public void agregarVueloTest()
        {
            Vuelo v = new Vuelo();
            v.Destino = "1";
            v.Origen = "2";
            v.IdAvion = 1;
            v.HoraPartida = "Prueba unitaria";
            v.HoraLlegada = "jueves, 9 de julio de 2015";
            v.Precio = 99;
            string resultado = vueloAD.guardarVuelo(v);
            Assert.AreEqual(resultado, "True");
            if (resultado == "True")
            {
                vueloAD.eliminarVueloPrueba();
            }

        }
        //*unittest
        [TestMethod()]
        public void buscarVuelosPorIdODestinoTest()
        {
            List<Vuelo> v = vueloAD.buscarVuelosPorIdoDestino(1, "2");
            Assert.AreNotEqual(v, null);
        }
        //*unittest
        [TestMethod()]
        public void modificarVueloTest()
        {
            Vuelo v = new Vuelo();
            v.Destino = "1";
            v.Origen = "2";
            v.IdAvion = 1;
            v.HoraPartida = "Prueba unitaria";
            v.HoraLlegada = "jueves, 9 de julio de 2015";
            v.Precio = 99;
            string resultado = vueloAD.guardarVuelo(v);

            if (resultado == "True")
            {
                Vuelo buscar = new Vuelo();
                buscar = vueloAD.buscarVueloPrueba();
                buscar.HoraLlegada = "Prueba Unitaria modificar";
                string resultadoM = vueloAD.modificarVuelo(buscar);
                Assert.AreEqual(resultadoM, "True");
                if (resultadoM == "True")
                {
                    vueloAD.eliminarVueloPrueba();
                }
            }
        }
        //*unittest
        [TestMethod()]
        public void agregarClienteTest()
        {
            Cliente cl = new ClienteRegular();
            cl.Id = "Prueba";
            cl.Nombre = "Prueba Unitaria";
            cl.Apellido = "Prueba";
            cl.Email = "email@hotmail.com";
            cl.Telefono = "99999999";
            cl.Estado = "Inactive";
            cl.TipoCliente = "Regular";
            cl.Millas = 1000;
            string resultado = clienteAD.guardarCliente(cl);
            Assert.AreEqual(resultado, "True");
            if (resultado == "True")
            {
                clienteAD.eliminarClientePrueba();
            }
        }
        //*unittest
        [TestMethod()]
        public void buscarClientesPorIdONombreTest()
        {
            List<Cliente> cl = clienteAD.listarClientesPorIdONombre("0", "ROBERTO");
            Assert.AreNotEqual(cl, null);
        }
        //*unittest
        [TestMethod()]
        public void modificarClienteTest()
        {
            Cliente cl = new ClienteRegular();
            cl.Id = "Prueba";
            cl.Nombre = "Prueba Unitaria";
            cl.Apellido = "Proyecto";
            cl.Email = "email@hotmail.com";
            cl.Telefono = "99999999";
            cl.Estado = "Inactive";
            cl.TipoCliente = "Regular";
            cl.Millas = 1000;
            string resultado = clienteAD.guardarCliente(cl);
            Assert.AreEqual(resultado, "True");
            if (resultado == "True")
            {
                Cliente buscar = new ClienteRegular();
                buscar = clienteAD.buscarClientePrueba();
                buscar.Apellido = "Prueba Unitaria modificar";
                string resultadoM = clienteAD.modificarCliente(buscar);
                Assert.AreEqual(resultadoM, "True");
                if (resultadoM == "True")
                {
                    clienteAD.eliminarClientePrueba();
                }
            }
        }
        //*unittest
        [TestMethod()]
        public void listarClientesTest()
        {
            List<Cliente> lista = clienteAD.listarClientes();
            Assert.AreNotEqual(lista, null);
        }
        //*unittest
        [TestMethod()]
        public void listarVuelosTest()
        {
            List<Vuelo> lista = vueloAD.listarVuelos();
            Assert.AreNotEqual(lista, null);
        }
        //*unittest
        [TestMethod()]
        public void agregarTiqueteTest()
        {
            Tiquete ti = new Tiquete();
            ti.Moneda = 3;
            ti.Estado = "Inactive";
            ti.IdCliente = "1";
            ti.IdVuelo = 1;
            ti.Asiento = 45;
            string resultado = tiqueteAD.guardarTiquete(ti);
            Assert.AreEqual(resultado, "True");
            if (resultado == "True")
            {
                tiqueteAD.eliminarTiquetePrueba();
            }
        }
        //*unittest
        [TestMethod()]
        public void buscarTiquetesPorClienteOVueloTest()
        {
            List<Tiquete> ti = tiqueteAD.buscarporClienteVuelo(" ", 1);
            Assert.AreNotEqual(ti, null);
        }
        //*unittest
        [TestMethod()]
        public void modificarTiqueteTest()
        {
            Tiquete ti = new Tiquete();
            ti.Moneda = 3;
            ti.Estado = "Inactive";
            ti.IdCliente = "1";
            ti.IdVuelo = 1;
            ti.Asiento = 45;
            string resultado = tiqueteAD.guardarTiquete(ti);
            Assert.AreEqual(resultado, "True");
            if (resultado == "True")
            {
                Tiquete buscar = new Tiquete();
                buscar = tiqueteAD.buscarTiquetePrueba();
                buscar.Estado = "Prueba Unitaria modificar";
                string resultadoM = tiqueteAD.modificarTiquete(buscar);
                Assert.AreEqual(resultadoM, "True");
                if (resultadoM == "True")
                {
                    tiqueteAD.eliminarTiquetePrueba();
                }
            }
        }
    }
}
