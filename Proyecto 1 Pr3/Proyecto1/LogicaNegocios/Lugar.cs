/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo lugar
//----Encargado: -Jenniffer Chinchilla Porras
/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Lugar
    {
        private int idLugar;
        private string nombre;
        private string latitud;
        private string longitud;

        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       
        public int IdLugar
        {
            get { return idLugar; }
            set { idLugar = value; }
        }
        
    }
}
