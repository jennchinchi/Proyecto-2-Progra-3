﻿/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo tiquete con los metodos
//---- guardar, modificar 
//----Encargado: -Jenniffer Chinchilla Porras
//---- Llave cambio = *creaticket
//
//----Fecha: 07-08-2015
//----Descripción: Cambio en metodos listar clientes,buscar por id,buscar por 
//----cliente y vuelo para hacer la consulta con linq
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *camblinqticket

//----Fecha creación: 16-08-2015
//----Descripción: Inclusion de nuevos métodos, eliminarTiquetePrueba, 
//----buscarTiquetePrueba para pruebas unitarias
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *unittest
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
    public class TiqueteDaImpl : ITiqueteDa
    {
        MyConnection myConnection = new MyConnection();
        //*creaticket
        public string guardarTiquete(Tiquete tiquete)
        {
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader tq;
            string resultado;

            comando.CommandText = "sp_RegisterTicket";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pCurrency", tiquete.Moneda);
            comando.Parameters.AddWithValue("@pTicketState", tiquete.Estado);
            comando.Parameters.AddWithValue("@pIdClient", tiquete.IdCliente);
            comando.Parameters.AddWithValue("@pIdFlight", tiquete.IdVuelo);
            comando.Parameters.AddWithValue("@pNumSeat", tiquete.Asiento);
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
        //*creaticket
        public string modificarTiquete(Tiquete tiquete)
        {
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader tq;
            string resultado;

            comando.CommandText = "sp_UpdateTicket";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId ", tiquete.IdTiquete);
            comando.Parameters.AddWithValue("@pCurrency", tiquete.Moneda);
            comando.Parameters.AddWithValue("@pTicketState", tiquete.Estado);
            comando.Parameters.AddWithValue("@pIdClient", tiquete.IdCliente);
            comando.Parameters.AddWithValue("@pIdFlight", tiquete.IdVuelo);
            comando.Parameters.AddWithValue("@pNumSeat", tiquete.Asiento);
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
        //*camblinqticket
        public List<Tiquete> listarTiquetes()
        {
            List<Tiquete> listaTiquete = new List<Tiquete>();
            MyConnection myConnection = new MyConnection();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Tiquete>();
            //SqlConnection conexion = myConnection.CreateConnection();
            //SqlCommand comando = myConnection.CreateCommand(conexion);
            //SqlDataReader ti;

            //comando.CommandText = "sp_listTickets";
            //comando.CommandType = CommandType.StoredProcedure;
            try
            {
                var listTickets = from lt in table
                                  select lt;
                foreach (Tiquete creatiquete in listTickets)
                {
                    listaTiquete.Add(creatiquete);
                }
                //    conexion.Open();
                //ti = comando.ExecuteReader();
                //while (ti.Read())
                //{
                //    Tiquete creatiquete = new Tiquete();
                //    creatiquete.IdTiquete = (int)ti["idTiquete"];
                //    creatiquete.Moneda = (int)ti["moneda"];
                //    creatiquete.Estado = (string)ti["estado"];
                //    creatiquete.IdCliente = (string)ti["cliente"];
                //    creatiquete.IdVuelo = (int)ti["vuelo"];
                //    creatiquete.Asiento = (int)ti["asiento"];

                //    listaTiquete.Add(creatiquete);

                //}
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    conexion.Close();
            //}
            return listaTiquete;
        }

        //*camblinqticket
        public Tiquete buscarporId(int idTiquete) 
        {
            Tiquete tiquete = new Tiquete();
            MyConnection myConnection = new MyConnection();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Tiquete>();
            //MyConnection myConnection = new MyConnection();
            //SqlConnection conexion = myConnection.CreateConnection();
            //SqlCommand comando = myConnection.CreateCommand(conexion);
            //SqlDataReader ti;

            //comando.CommandText = "sp_searchByIdTicket";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@pId ", idTiquete);
            try
            {
                var listTickets = from lt in table
                                  where lt.IdTiquete == idTiquete
                                  select lt;

                foreach (Tiquete b in listTickets)
                {
                    tiquete = b;
                }
                //conexion.Open();
                //ti = comando.ExecuteReader();
                //while (ti.Read())
                //{
                //    tiquete.IdTiquete = (int)ti["idTiquete"];
                //    tiquete.Moneda = (int)ti["moneda"];
                //    tiquete.Estado = (string)ti["estado"];
                //    tiquete.IdCliente = (string)ti["cliente"];
                //    tiquete.IdVuelo = (int)ti["vuelo"];
                //    tiquete.Asiento = (int)ti["asiento"];
                //}
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    //conexion.Close();
            //}
            return tiquete;
        }
        //*camblinqticket
        public List<Tiquete> buscarporClienteVuelo(string idCliente,int idVuelo)
        {
            List<Tiquete> listaTiquete = new List<Tiquete>();
            MyConnection myConnection = new MyConnection();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Tiquete>();
            //Tiquete tiquete = new Tiquete();
            //MyConnection myConnection = new MyConnection();
            //SqlConnection conexion = myConnection.CreateConnection();
            //SqlCommand comando = myConnection.CreateCommand(conexion);
            //SqlDataReader ti;

            //comando.CommandText = "sp_searchByClienteByVuelo";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@pIdCliente", idCliente);
            //comando.Parameters.AddWithValue("@pIdFlight", idVuelo);
            try
            {
                var listTickets = from lt in table
                                  where lt.IdCliente == idCliente || lt.IdVuelo == idVuelo
                                  select lt;
                foreach (Tiquete creatiquete in listTickets)
                {
                    listaTiquete.Add(creatiquete);
                }
                //conexion.Open();
                //ti = comando.ExecuteReader();
                //while (ti.Read())
                //{
                //    tiquete.IdTiquete = (int)ti["idTiquete"];
                //    tiquete.Moneda = (int)ti["moneda"];
                //    tiquete.Estado = (string)ti["estado"];
                //    tiquete.IdCliente = (string)ti["cliente"];
                //    tiquete.IdVuelo = (int)ti["vuelo"];
                //    tiquete.Asiento = (int)ti["asiento"];
                //    listaTiquete.Add(tiquete);
                //}
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    conexion.Close();
            //}
            return listaTiquete;
        }
        //*unittest
        public void eliminarTiquetePrueba()
        {
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Tiquete>();
            var result = from tiquete in table
                         where tiquete.Moneda == 3
                         select tiquete;
            foreach (Tiquete delete in result)
            {
                table.DeleteOnSubmit(delete);
                datacontext.SubmitChanges();
            }
        }
        //unittes
        public Tiquete buscarTiquetePrueba()
        {
            Tiquete returnTiquete = new Tiquete();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Tiquete>();
            var result = from tiquete in table
                         where tiquete.Moneda == 3
                         select tiquete;
            foreach (Tiquete delete in result)
            {
                returnTiquete = delete;
            }
            return returnTiquete;
        }

    }
}
