/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo lugar
//----Encargado: -Jenniffer Chinchilla Porras
//
//----Fecha: 14-08-2015
//----Descripción: Se incluyen cambios en clase para hacer consultas con linq
//----Encargado: kevin serrano arroyo
//----
/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////LINQtoSQL lugar
using System.Data.Linq;
using System.Data.Linq.Mapping;


//properties de la clase 
namespace LogicaNegocios
{
    ////LINQtoSQL lugar
    [Table(Name = "Place")]
    public class Lugar
    {
        #region Variables
        private int idLugar;
        private string nombre;
        private string latitud;
        private string longitud;
        #endregion
        ////LINQtoSQL lugar
         [Column(Name = "longitude")]
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
         ////LINQtoSQL lugar
         [Column(Name = "latitude")]
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
         ////LINQtoSQL lugar
         [Column(Name = "name")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
         ////LINQtoSQL lugar
        [Column(Name = "idPlace", IsPrimaryKey = true, DbType = "int NOT NULL", IsDbGenerated = true)]
        public int IdLugar
        {
            get { return idLugar; }
            set { idLugar = value; }
        }
        
    }
}
