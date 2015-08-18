/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelo
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *creavuelo

//----Fecha creación: 16-08-2015
//----Descripción: Inclusion de nuevos métodos, eliminarVueloPrueba, 
//----buscarVueloPrueba para pruebas unitarias
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *unittest

//----Fecha: 15-08-2015 // 17-08-2015
//----Descripción: Modifican los metodos de buscarVuelos // Modificación de public List<Vuelo> listarVuelos() 
//----Encargado: -Ronald Moreira Artavia
//----Llave= cambBuscar // camblistarVuelos

/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AccesoDatos
{
    public class VueloDaImpl : IVueloDa
    {
        MyConnection myConnection = new MyConnection();
        //*creavuelo
        public string guardarVuelo(Vuelo vuelo)
        {
            
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            string resultado;

            comando.CommandText = "sp_RegisterFlight";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPlane", vuelo.IdAvion);
            comando.Parameters.AddWithValue("@origen", vuelo.Origen);
            comando.Parameters.AddWithValue("@destino", vuelo.Destino);
            comando.Parameters.AddWithValue("@horaPartida", vuelo.HoraPartida);
            comando.Parameters.AddWithValue("@horaLlegada", vuelo.HoraLlegada);
            comando.Parameters.AddWithValue("@price", vuelo.Precio);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                resultado = "True";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                resultado = ex.Message;
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }
        //*creavuelo
        public string modificarVuelo(Vuelo vuelo)
        {
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader fl;
            string resultado;

            comando.CommandText = "sp_UpdateFlight";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId", vuelo.IdVuelo);
            comando.Parameters.AddWithValue("@idPlane", vuelo.IdAvion);
            comando.Parameters.AddWithValue("@origen", vuelo.Origen);
            comando.Parameters.AddWithValue("@destino", vuelo.Destino);
            comando.Parameters.AddWithValue("@horaPartida", vuelo.HoraPartida);
            comando.Parameters.AddWithValue("@horaLlegada", vuelo.HoraLlegada);
            comando.Parameters.AddWithValue("@price", vuelo.Precio);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                resultado = "True";
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                resultado = ex.Message;
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }
        //*creavuelo

        public List<Vuelo> listarVuelos() // camblistarVuelos
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();
            MyConnection myConnection = new MyConnection();

            DataContext datacontext = new DataContext(myConnection.SQLConnection);

            var Table = datacontext.GetTable<Vuelo>();

            try
            {
                //conexion.Open();
                //vu = comando.ExecuteReader();
                //while (vu.Read())
                //{
                //    Vuelo creaVuelo = new Vuelo();
                //    creaVuelo.IdVuelo = (int)vu["vuelo"];
                //    creaVuelo.IdAvion = (int)vu["avion"];
                //    creaVuelo.Origen = (string)vu["origen"];
                //    creaVuelo.Destino = (string)vu["destino"];
                //    creaVuelo.DisplayOrigen = (string)vu["origenDisplay"];
                //    creaVuelo.DisplayDestino = (string)vu["destinoDisplay"];
                //    creaVuelo.HoraPartida = (string)vu["horaSalida"];
                //    creaVuelo.HoraLlegada = (string)vu["horaLlegada"];
                //    creaVuelo.Precio = double.Parse(vu["precio"].ToString());
                //    listaVuelos.Add(creaVuelo);
                var listaVuelo = from listVuelo in Table
                                 select listVuelo;

                foreach (Vuelo v in listaVuelo)
                {
                    listaVuelos.Add(v);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listaVuelos;
        }

            
        //*creavuelo
        public Vuelo buscarporId(int idVuelo)
        {
            Vuelo vuelo = new Vuelo();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader vu;

            comando.CommandText = "sp_searchByIdFlight";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId ", idVuelo);
            try
            {
                conexion.Open();
                vu = comando.ExecuteReader();
                while (vu.Read())
                {
                    vuelo.IdVuelo = (int)vu["vuelo"];
                    vuelo.IdAvion = (int)vu["avion"];
                    vuelo.Origen = (string)vu["origen"];
                    vuelo.Destino = (string)vu["destino"];
                    vuelo.HoraPartida = (string)vu["horaSalida"];
                    vuelo.HoraLlegada = (string)vu["horaLlegada"];
                    vuelo.Precio = double.Parse(vu["precio"].ToString());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return vuelo;
        }
        //*creavuelo
        public List<Vuelo> buscarVuelosPorIdoDestino(int id, string destino)
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader vu;

            //comando.CommandText = "sp_searchByIdFlightORDestino";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@pId ", id);
            //comando.Parameters.AddWithValue("@pDestino ", destino);
            //try
            //{
            //    conexion.Open();
            //    vu = comando.ExecuteReader();
            //    while (vu.Read())
            //    {
            //        Vuelo creaVuelo = new Vuelo();
            //        creaVuelo.IdVuelo = (int)vu["vuelo"];
            //        creaVuelo.IdAvion = (int)vu["avion"];
            //        creaVuelo.Origen = (string)vu["origen"];
            //        creaVuelo.Destino = (string)vu["destino"];
            //        creaVuelo.HoraPartida = (string)vu["horaSalida"];
            //        creaVuelo.HoraLlegada = (string)vu["horaLlegada"];
            //        creaVuelo.Precio = double.Parse(vu["precio"].ToString());
            //        listaVuelos.Add(creaVuelo);
            DataContext datacontext = new DataContext(myConnection.SQLConnection);

            var Table = datacontext.GetTable<Vuelo>();


            try
            {
                var buscarPorIdDestino = from vueloId in Table
                                         where vueloId.IdVuelo == id || vueloId.Destino == destino
                                         select vueloId;
                foreach (Vuelo v in buscarPorIdDestino)
                {
                    listaVuelos.Add(v);
                }

                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return listaVuelos;
        }
        //*creavuelo
        public List<int> listaAsientosReservados(int idVuelo)
        {
            List<int> asientos = new List<int>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader at;

            try
            {
                conexion.Open();
                at = comando.ExecuteReader();
                while (at.Read())
                {
                    asientos.Add((int)at["asiento"]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return asientos;
        }
        //*unittest
        public void eliminarVueloPrueba() 
        {
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Vuelo>();
            var result = from vuelo in table
                         where vuelo.HoraPartida == "Prueba unitaria"
                              select vuelo;
            foreach (Vuelo delete in result)
            {
                table.DeleteOnSubmit(delete);
                datacontext.SubmitChanges();
            }
        }
        //*unittest
        public Vuelo buscarVueloPrueba()
        {
            Vuelo returnVuelo = new Vuelo();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Vuelo>();
            var result = from vuelo in table
                         where vuelo.HoraPartida == "Prueba unitaria"
                         select vuelo;
            foreach (Vuelo delete in result)
            {
                returnVuelo = delete;
            }
            return returnVuelo;
        }
    }
}
