/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelo
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *creavuelo

//----Fecha: 15-08-2015
//----Descripción: Modifican los metodos de buscarVuelos
//----Encargado: -Ronald Moreira Artavia
//----Llave= cambBuscar

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
            var Table2 = datacontext.GetTable<Lugar>();

            try
            {
                var listaVuelo = from listVuelo in Table
                                 select listVuelo;

                foreach (Vuelo v in listaVuelo)
                {
                    v.DisplayOrigen = (from place in Table2
                                      where (place.IdLugar == int.Parse(v.Origen))
                                      select place.Nombre).Single();
                    v.DisplayDestino = (from place in Table2
                                       where (place.IdLugar == int.Parse(v.Destino))
                                       select place.Nombre).Single();
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
        public Vuelo buscarporId(int idVuelo) //cambBuscar
        {
            Vuelo vuelo = new Vuelo();
            MyConnection myConnection = new MyConnection();

            DataContext datacontext = new DataContext(myConnection.SQLConnection);

            var Table = datacontext.GetTable<Vuelo>();

            try
            {
                var buscarPorIdVuelo = from vueloId in Table
                                       where vueloId.IdVuelo == idVuelo
                                       select vueloId;
                foreach (Vuelo v in buscarPorIdVuelo)
                {
                    vuelo = v;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return vuelo;
        }
        //*creavuelo
        public List<Vuelo> buscarVuelosPorIdoDestino(int id, string destino)//cambBuscar
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();
            MyConnection myConnection = new MyConnection();

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

            comando.CommandText = "sp_listaAsientosReservados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pIdFlight ", idVuelo);
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
