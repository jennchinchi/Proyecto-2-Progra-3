﻿/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo cliente
//----Encargado: Roberto Mora Castro

//----Fecha creación: 27-06-2014
//----Descripción: Inclusion de nuevos métodos, listarClientesPorIDoNombre
//----para busquedas en el listview
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
    public class ClienteDaImpl : IClienteDa
    {
        public Cliente definirTipoCliente(string tipo)
        {
            switch (tipo)
            {
                case "Platinum":
                    return new ClientePlatino();
                    break;
                case "Diamond":
                    return new ClienteDiamante();
                    break;
                default:
                    return new ClienteRegular();
                    break;
            }
        }
        public string guardarCliente(Cliente cliente)
        {
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            string resultado;

            comando.CommandText = "sp_Register";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@pId", cliente.Id));
            comando.Parameters.Add(new SqlParameter("@pName ", cliente.Nombre));
            comando.Parameters.Add(new SqlParameter("@pLastname", cliente.Apellido));
            comando.Parameters.Add(new SqlParameter("@pEmail", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@pPhone", cliente.Telefono));
            comando.Parameters.Add(new SqlParameter("@pClientState", cliente.Estado));
            comando.Parameters.Add(new SqlParameter("@pClientType", cliente.TipoCliente));
            comando.Parameters.Add(new SqlParameter("@pmillas", cliente.Millas));
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
        public string modificarCliente(Cliente cliente)
        {
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            string resultado;

            comando.CommandText = "sp_UpdateClient";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@pId", cliente.Id));
            comando.Parameters.Add(new SqlParameter("@pName ", cliente.Nombre));
            comando.Parameters.Add(new SqlParameter("@pLastname", cliente.Apellido));
            comando.Parameters.Add(new SqlParameter("@pEmail", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@pPhone", cliente.Telefono));
            comando.Parameters.Add(new SqlParameter("@pClientState", cliente.Estado));
            comando.Parameters.Add(new SqlParameter("@pClientType", cliente.TipoCliente));
            comando.Parameters.Add(new SqlParameter("@pmiles", cliente.Millas));
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

        public List<Cliente> listarClientes()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cl;

            comando.CommandText = "sp_listClients";
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Open();
                cl = comando.ExecuteReader();
                while (cl.Read())
                {
                    Cliente creaCliente = definirTipoCliente((string)cl["tipoCliente"]);
                    creaCliente.Id = (string)cl["identificacion"];
                    creaCliente.Nombre = (string)cl["nombre"];
                    creaCliente.Apellido = (string)cl["apellido"];
                    creaCliente.Email = (string)cl["email"];
                    creaCliente.Telefono = (string)cl["telefono"];
                    creaCliente.Estado = (string)cl["estado"];
                    creaCliente.TipoCliente = (string)cl["tipoCliente"];
                    creaCliente.Millas = int.Parse(cl["millas"].ToString());

                    listaCliente.Add(creaCliente);

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
            return listaCliente;
        }
        public Cliente buscarporId(int idCliente)
        {
            Cliente cliente = null;
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cl;

            comando.CommandText = "sp_searchById";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId ", idCliente);
            try
            {
                conexion.Open();
                cl = comando.ExecuteReader();
                while (cl.Read())
                {
                    cliente = definirTipoCliente((string)cl["tipoCliente"]);
                    cliente.Id = (string)cl["identificacion"];
                    cliente.Nombre = (string)cl["nombre"];
                    cliente.Apellido = (string)cl["apellido"];
                    cliente.Email = (string)cl["email"];
                    cliente.Telefono = (string)cl["telefono"];
                    cliente.Estado = (string)cl["estado"];
                    cliente.TipoCliente = (string)cl["tipoCliente"];
                    cliente.Millas = int.Parse(cl["millas"].ToString());
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
            return cliente;
        }

        public List<Cliente> listarClientesPorIdONombre(string id, string nombre)
        {
            List<Cliente> listaCliente = new List<Cliente>();
            MyConnection myConnection = new MyConnection();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cl;

            comando.CommandText = "sp_searchClienteByIdORNombre";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pId", id);
            comando.Parameters.AddWithValue("@pNombre", nombre);
            try
            {
                conexion.Open();
                cl = comando.ExecuteReader();
                while (cl.Read())
                {
                    Cliente creaCliente = definirTipoCliente((string)cl["tipoCliente"]);
                    creaCliente.Id = (string)cl["identificacion"];
                    creaCliente.Nombre = (string)cl["nombre"];
                    creaCliente.Apellido = (string)cl["apellido"];
                    creaCliente.Email = (string)cl["email"];
                    creaCliente.Telefono = (string)cl["telefono"];
                    creaCliente.Estado = (string)cl["estado"];
                    creaCliente.TipoCliente = (string)cl["tipoCliente"];
                    creaCliente.Millas = int.Parse(cl["millas"].ToString());

                    listaCliente.Add(creaCliente);

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
            return listaCliente;
        }
    }
}
