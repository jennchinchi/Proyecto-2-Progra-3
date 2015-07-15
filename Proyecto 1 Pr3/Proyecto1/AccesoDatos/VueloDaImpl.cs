﻿/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelo
//----Encargado: -Jenniffer Chinchilla Porras
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

namespace AccesoDatos
{
    public class VueloDaImpl : IVueloDa
    {
        public string guardarVuelo(Vuelo vuelo)
        {
            MyConnection myConnection = new MyConnection();
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

        public List<Vuelo> listarVuelos()
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader vu;

            comando.CommandText = "sp_listFlights2";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Open();
                vu = comando.ExecuteReader();
                while (vu.Read())
                {
                    Vuelo creaVuelo = new Vuelo();
                    creaVuelo.IdVuelo = (int)vu["vuelo"];
                    creaVuelo.IdAvion = (int)vu["avion"];
                    //creaVuelo.Origen = (string)vu["origen"];
                    //creaVuelo.Destino = (string)vu["destino"];
                    creaVuelo.DisplayOrigen = (string)vu["origenDisplay"];
                    creaVuelo.DisplayDestino = (string)vu["destinoDisplay"];
                    creaVuelo.HoraPartida = (string)vu["horaSalida"];
                    creaVuelo.HoraLlegada = (string)vu["horaLlegada"];
                    creaVuelo.Precio = double.Parse(vu["precio"].ToString());
                    listaVuelos.Add(creaVuelo);

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

        public List<Vuelo> buscarVuelosPorIdoDestino(int id, string destino)
        {
            List<Vuelo> listaVuelos = new List<Vuelo>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader vu;

            comando.CommandText = "sp_searchByIdFlightORDestino";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId ", id);
            comando.Parameters.AddWithValue("@pDestino ", destino);
            try
            {
                conexion.Open();
                vu = comando.ExecuteReader();
                while (vu.Read())
                {
                    Vuelo creaVuelo = new Vuelo();
                    creaVuelo.IdVuelo = (int)vu["vuelo"];
                    creaVuelo.IdAvion = (int)vu["avion"];
                    creaVuelo.Origen = (string)vu["origen"];
                    creaVuelo.Destino = (string)vu["destino"];
                    creaVuelo.HoraPartida = (string)vu["horaSalida"];
                    creaVuelo.HoraLlegada = (string)vu["horaLlegada"];
                    creaVuelo.Precio = double.Parse(vu["precio"].ToString());
                    listaVuelos.Add(creaVuelo);

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
    }
}
