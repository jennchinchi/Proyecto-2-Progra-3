//---------------- HISTORIAL DE MODIFICACION -----------------
//------------------------------------------------------------
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación de gestor encargado de llamar a 
//---- cada modulo.
//---- Los metodos llamados son los de mantenimiento de cada  clase: 
//---- agregar, modificar, buscar
//----Encargado: -Jenniffer Chinchilla Porras
//---- Llave cambio = *crearestor
//---------------- HISTORIAL DE MODIFICACION -----------------
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios;
using AccesoDatos;

namespace Presentacion
{
    public static class Gestor
    {
        //*crearestor
        private static IAvionDa avionAD = new AvionDaImpl();
        private static ITiqueteDa tiqueteAD = new TiqueteDaImpl();
        private static IVueloDa vueloAD = new VueloDaImpl();
        private static IClienteDa clienteAD = new ClienteDaImpl();
        private static ILugarDa lugarAD = new LugarDaImpl();
        //*crearestor
        public static Avion buscarAvionPorId(int id)
        {
            return avionAD.buscarAvionPorId(id);
        }
        //**crearestor
        public static List<Avion> listarAviones()
        {
            return avionAD.listarAviones();
        }
        //*crearestor
        public static Lugar buscarLugarPorId(int id)
        {
            return lugarAD.buscarLugarPorId(id);
        }
        //*crearestor
        public static List<Lugar> listarLugares()
        {
            return lugarAD.listarLugares();
        }
        //*crearestor
        public static string agregarVuelo(int idAvion,string origen,string destino,string horaPartida,string horaLlegada, string precio)
        {
            Vuelo v = new Vuelo();
            v.IdAvion = idAvion;
            v.Origen = origen;
            v.Destino = destino;
            v.HoraPartida = horaPartida;
            v.HoraLlegada = horaLlegada;
            v.Precio = double.Parse(precio);
            return vueloAD.guardarVuelo(v);
        }
        //*crearestor
        public static List<Vuelo> buscarVuelosPorIdODestino(string id, string destino)
        {
            if(id.Equals("") && destino.Equals("")){
                return vueloAD.listarVuelos();
            }else{
                if (id.Equals(""))
                {
                    id = "-1";
                }
                if (destino.Equals(""))
                {
                    destino = "1gmq1z";
                }
                return vueloAD.buscarVuelosPorIdoDestino(int.Parse(id), destino);
            }
        }
        //*crearestor
        public static string modificarVuelo(Vuelo v)
        {
            return vueloAD.modificarVuelo(v);
        }
        //*crearestor
        public static string agregarCliente(string id, string nombre, string apellido, string email, string telefono, string estado, string tipo, int millas)
        {
            Cliente c = new ClienteRegular();
            c.Id = id;
            c.Nombre = nombre;
            c.Apellido = apellido;
            c.Email = email;
            c.Telefono = telefono;
            c.Estado = estado;
            c.TipoCliente = tipo;
            c.Millas = millas;
            return clienteAD.guardarCliente(c);
        }
        //*crearestor
        public static List<Cliente> buscarClientesPorIdONombre(string id, string nombre)
        {
            if (id.Equals("") && nombre.Equals(""))
            {
                return clienteAD.listarClientes();
            }
            else
            {
                if (id.Equals(""))
                {
                    id = "-1";
                }
                if (nombre.Equals(""))
                {
                    nombre = "1gmq1z";
                }
                return clienteAD.listarClientesPorIdONombre(id, nombre);
            }
        }
        //*crearestor
        public static string modificarCliente(Cliente cl)
        {
            return clienteAD.modificarCliente(cl);
        }
        //*crearestor
        public static List<Cliente> listarClientes()
        {
            return clienteAD.listarClientes();
        }
        //*crearestor
        public static List<Vuelo> listarVuelos()
        {
            return vueloAD.listarVuelos();
        }
        //*crearestor
        public static List<int> listaAsientosReservados(int idVuelo)
        {
            return vueloAD.listaAsientosReservados(idVuelo);
        }
        //*crearestor
        public static string agregarTiquete(string estado, Cliente cliente, int idVuelo, int moneda, int asiento)
        {
            Tiquete ti = new Tiquete();
            ti.Estado = estado;
            ti.IdCliente = cliente.Id;
            ti.IdVuelo = idVuelo;
            ti.Moneda = moneda;
            ti.Asiento = asiento;
            string result = tiqueteAD.guardarTiquete(ti);
            if (result.Equals("True"))
            {
                cliente.Millas += cliente.MillasAGanar;
                result = modificarCliente(cliente);
            }
            return result;
        }
        //*crearestor
        public static List<Tiquete> buscarTiquetesPorClienteOVuelo(string idCliente, string idVuelo)
        {
            if (idCliente.Equals("") && idVuelo.Equals(""))
            {
                return tiqueteAD.listarTiquetes();
            }
            else
            {
                if (idVuelo.Equals(""))
                {
                    idVuelo = "-1";
                }

                return tiqueteAD.buscarporClienteVuelo(idCliente, int.Parse(idVuelo));
            }
        }
        //*crearestor
        public static string modificarTiquete(Tiquete ti)
        {
            return tiqueteAD.modificarTiquete(ti);
        }
    }
}
