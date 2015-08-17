/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo de lugares
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *crealugar

//----Fecha creación: 28-06-2015
//----Descripción: Inclusion de nuevo método, listarLugares para 
//----combobox en vuelo
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *combovuelo
//
//----Fecha modificacion: 16-08-2015
//----Descripción: modficacion de los métodos a linq de listarLugares para 
//----combobox en vuelo y busqueda de lugar por id 
//----Encargado: kevin serrano 
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
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AccesoDatos
{
    public class LugarDaImpl : ILugarDa
    {
        //*crealugar
        public Lugar buscarLugarPorId(int id)
        {
            Lugar lu = new Lugar(); // se crea la instancia de la lista que va a contener la tabla lugar
            MyConnection myConnection = new MyConnection();//instancia de la conexion
            DataContext datacontext = new DataContext(myConnection.SQLConnection)// instancia de datacontex y se pasa la conexion del servidor
            var table = datacontext.GetTable<Lugar>();// se asigna la conexion a una variable la cual contiene toda la tabla

            //MyConnection myConnection = new MyConnection();
            //SqlConnection conexion = myConnection.CreateConnection();
            //SqlCommand comando = myConnection.CreateCommand(conexion);
            //SqlDataReader al;

            //comando.CommandText = "sp_searchByIdPlace";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@pId ", id);
            try
            {
                var listPlace = from lt in table // se crea una variable y se le asigna la consulta
                                  where lt.IdLugar == id// se hace la comparacion del valor que se esta consultando
                                  select lt;

                foreach (Lugar b in listPlace)// se recorre la variable y se iguala el valor de la consulta
                {
                    lu = b;
                }
                //conexion.Open();
                //al = comando.ExecuteReader();
                //while (al.Read())
                //{
                //    lu = new Lugar();
                //    lu.IdLugar = (int)al["idLugar"];
                //    lu.Nombre = (string)al["nombre"];
                //    lu.Latitud = (string)al["latitud"];
                //    lu.Longitud = (string)al["longitud"];
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
            return lu;// muestra el valor consultado en la variable lu
        }
        //*combovuelo
        public List<Lugar> listarLugares()
        {
            List<Lugar> listaLugar = new List<Lugar>(); // se crea la instancia de la lista que va a contener la tabla lugar
            MyConnection myConnection = new MyConnection();//instancia de la conexion
            DataContext datacontext = new DataContext(myConnection.SQLConnection);// instancia de datacontex y se pasa la conexion del servidor
            var table = datacontext.GetTable<Lugar>();// se asigna la conexion a una variable la cual contiene toda la tabla
            //MyConnection myConnection = new MyConnection();
            //SqlConnection conexion = myConnection.CreateConnection();
            //SqlCommand comando = myConnection.CreateCommand(conexion);
            //SqlDataReader pl;

            //comando.CommandText = "sp_listPlace";
            //comando.CommandType = CommandType.StoredProcedure;
            try
            {
                var listPlace = from lt in table// se crea una variable y se le asigna la consulta
                                  select lt;
                foreach (Lugar creaLugar in listPlace)// se recorre la variable y se le agrega el valor de la consulta
                {
                    listaLugar.Add(creaLugar);
                }
                //conexion.Open();
                //pl = comando.ExecuteReader();
                //while (pl.Read())
                //{
                //    Lugar creaLugar = new Lugar();
                //    creaLugar.IdLugar = (int)pl["idLugar"];
                //    creaLugar.Nombre = (string)pl["nombre"];
                //    creaLugar.Latitud = (string)pl["latitud"];
                //    creaLugar.Longitud = (string)pl["longitud"];

                //    listaLugar.Add(creaLugar);

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
            return listaLugar;//muestra el valor consultado en la variable listaLugar
        }
    }
}
