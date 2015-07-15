/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo tiquete
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
    public class Tiquete
    {
        private int idTiquete;
        private int moneda;
        private String estado;
        private String idCliente;
        private int idVuelo;
        private int asiento;

        public int IdTiquete
        {
            get { return idTiquete; }
            set { idTiquete = value; }
        }
        public int Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public String IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public int IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }
        public int Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

    }
}
