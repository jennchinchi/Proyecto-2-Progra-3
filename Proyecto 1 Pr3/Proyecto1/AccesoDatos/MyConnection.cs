/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 
//----Descripción: Creación de clase conexion a la bd
//----Encargado: -Roberto Mora Castro

//----Fecha creación: 19-06-2015
//----Descripción: Modificacion de clase para probar cambios
//----Encargado: -Jenniffer Chinchilla Porras
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
 

namespace AccesoDatos
{
    class MyConnection
    {    //private string sqlConnection = "Data Source=RobertoDesktop;Initial Catalog=Flights;User ID=sa;Password=123456";
        private string sqlConnection = "Data Source=NANI\\SQLEXPRESS;Initial Catalog=Flights; User ID=user;Password=12345";

        public string SQLConnection
        {
            get
            {
                return sqlConnection;
            }
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            return connection;
        }

        public SqlCommand CreateCommand(SqlConnection cnn)
        {
            SqlCommand sqlcommand = new SqlCommand(sqlConnection, cnn);
            return sqlcommand;
        }

    }
}
