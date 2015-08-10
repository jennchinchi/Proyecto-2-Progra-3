/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo de lugares
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *crealugar

//----Fecha creación: 28-06-2014
//----Descripción: Inclusion de nuevo método, listarLugares para 
//----combobox en vuelo
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *combovuelo
/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LogicaNegocios;

namespace AccesoDatos
{
    public class LugarDaImpl : ILugarDa
    {
        //*crealugar
        public Lugar buscarLugarPorId(int id)
        {
            Lugar lu = null;
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader al;

            comando.CommandText = "sp_searchByIdPlace";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId ", id);
            try
            {
                conexion.Open();
                al = comando.ExecuteReader();
                while (al.Read())
                {
                    lu = new Lugar();
                    lu.IdLugar = (int)al["idLugar"];
                    lu.Nombre = (string)al["nombre"];
                    lu.Latitud = (string)al["latitud"];
                    lu.Longitud = (string)al["longitud"];
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
            return lu;
        }
        //*combovuelo
        public List<Lugar> listarLugares()
        {
            List<Lugar> listaLugar = new List<Lugar>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader pl;

            comando.CommandText = "sp_listPlace";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Open();
                pl = comando.ExecuteReader();
                while (pl.Read())
                {
                    Lugar creaLugar = new Lugar();
                    creaLugar.IdLugar = (int)pl["idLugar"];
                    creaLugar.Nombre = (string)pl["nombre"];
                    creaLugar.Latitud = (string)pl["latitud"];
                    creaLugar.Longitud = (string)pl["longitud"];

                    listaLugar.Add(creaLugar);

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
            return listaLugar;
        }
    }
}
