/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo avion
//----Encargado: -Dennis Hurtado Prada
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
    public class Avion
    {
        private int idAvion;
        private int asientos;
        private String marca;
        public int IdAvion
        {
            get { return idAvion; }
            set { idAvion = value; }
        }
        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
    }
}
