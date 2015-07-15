/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelo
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
    public class Vuelo
    {
        private int idVuelo;
        private int idAvion;
        private String origen;
        private String destino;
        private String horaPartida;
        private String horaLlegada;
        private double precio;
        private String displayOrigen;
        private String displayDestino;

        public String DisplayDestino
        {
            get { return displayDestino; }
            set { displayDestino = value; }
        }
        public String DisplayOrigen
        {
            get { return displayOrigen; }
            set { displayOrigen = value; }
        }
      

        public int IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }
        public int IdAvion
        {
            get { return idAvion; }
            set { idAvion = value; }
        }
        public String Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        public String Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public String HoraPartida
        {
            get { return horaPartida; }
            set { horaPartida = value; }
        }

        public String HoraLlegada
        {
            get { return horaLlegada; }
            set { horaLlegada = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string cmbDisplay
        {
            get { return displayOrigen + "-" + displayDestino; }
        }
    }
}
