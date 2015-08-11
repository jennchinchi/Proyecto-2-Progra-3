/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo avion
//----Encargado: -Dennis Hurtado Prada
//---- Llave cambio = *creaavion

//----Fecha creación: 11-07-2014
//----Descripción: cambio a linq to sql
//----Encargado: -Denis Hurtado Prada
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
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AccesoDatos
{
    public class AvionDaImpl : IAvionDa
    {
        //*creaavion
        public Avion buscarAvionPorId(int id)
        {
            Avion av = new Avion();
            MyConnection myConnection = new MyConnection();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Avion>();


            try
            {
                var listaAvion = from lt in table
                                 where lt.IdAvion == id
                                 select lt;
                foreach (Avion b in listaAvion)
                {
                    av = b;
                }



                /*SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);
                SqlDataReader al;

                comando.CommandText = "sp_searchByIdPlane";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@pId ", id);
                try
                {
                    conexion.Open();
                    al = comando.ExecuteReader();
                    while (al.Read())
                    {
                        av = new Avion();
                        av.IdAvion = (int)al["idAvion"];
                        av.Marca = (string)al["marca"];
                        av.Asientos = (int)al["cantidadAsientos"];
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
                return av;*/
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return av;

        }
        //*listarAviones
        public List<Avion> listarAviones()
        {
            List<Avion> listaavion = new List<Avion>();
            MyConnection myConnection = new MyConnection();
            DataContext datacontext = new DataContext(myConnection.SQLConnection);
            var table = datacontext.GetTable<Avion>();

            try
            {
                var plane = from lt in table
                            select lt;
                foreach (Avion b in plane)
                {
                    listaavion.Add(b);
                }
                // SqlConnection conexion = myConnection.CreateConnection();
                // SqlCommand comando = myConnection.CreateCommand(conexion);
                // SqlDataReader pl;

                /* comando.CommandText = "sp_listPlane";
                 comando.CommandType = CommandType.StoredProcedure;
                 try
                 {
                     conexion.Open();
                     pl = comando.ExecuteReader();
                     while (pl.Read())
                     {
                         Avion creaavion = new Avion();
                         creaavion.IdAvion = (int)pl["idAvion"];
                         creaavion.Marca = (string)pl["marca"];
                         creaavion.Asientos = (int)pl["cantidadAsientos"];

                         listaavion.Add(creaavion);

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
                return listaavion;*/
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listaavion;
        }
    }
} 
