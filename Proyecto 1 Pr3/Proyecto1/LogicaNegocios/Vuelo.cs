/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelo
//----Encargado: -Jenniffer Chinchilla Porras

//----Fecha: 09-08-2015
//----Descripción: Se incluyen cambios en clase para hacer consultas con linq
//----Encargado: -Ronald Moreira Artavia
//----Llave= cambLinqFlight


/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LogicaNegocios
{
    //cambLinqFlight
    [Table(Name = "Flight")]

    public class Vuelo
    {
        private int idVuelo;
        private int idAvion;
        private String origen;
        private String destino;
        private String horaPartida;
        private String horaLlegada;
        private double precio; //cambLinqFlight
        private String displayOrigen;
        private String displayDestino;

        //cambLinqFlight
        [Column(Name = "idFlight", IsPrimaryKey = true, DbType = "int NOT NULL", IsDbGenerated = true)]
        public int IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }

        //cambLinqFlight
        [Column(Name = "idPlane")]
        public int IdAvion
        {
            get { return idAvion; }
            set { idAvion = value; }
        }

        //cambLinqFlight
        [Column(Name = "origen")]
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        //cambLinqFlight
        [Column(Name = "destino")]
        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        //cambLinqFlight
        [Column(Name = "horaPartida")]
        public string HoraPartida
        {
            get { return horaPartida; }
            set { horaPartida = value; }
        }

        //cambLinqFlight
        [Column(Name = "horaLlegada")]
        public string HoraLlegada
        {
            get { return horaLlegada; }
            set { horaLlegada = value; }
        }

        //cambLinqFlight
        [Column(Name = "price")]
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        //cambLinqFlight
        public String DisplayDestino
        {
            get { return displayDestino; }
            set { displayDestino = value; }
        }
        //cambLinqFlight
        public String DisplayOrigen
        {
            get { return displayOrigen; }
            set { displayOrigen = value; }
        }

        //cambLinqFlight
        public string cmbDisplay
        {
            get { return displayOrigen + "-" + displayDestino; }
        }


        //public String DisplayDestino
        //{
        //    get { return displayDestino; }
        //    set { displayDestino = value; }
        //}
        //public String DisplayOrigen
        //{
        //    get { return displayOrigen; }
        //    set { displayOrigen = value; }
        //}


        //public int IdVuelo
        //{
        //    get { return idVuelo; }
        //    set { idVuelo = value; }
        //}
        //public int IdAvion
        //{
        //    get { return idAvion; }
        //    set { idAvion = value; }
        //}
        //public String Origen
        //{
        //    get { return origen; }
        //    set { origen = value; }
        //}
        //public String Destino
        //{
        //    get { return destino; }
        //    set { destino = value; }
        //}

        //public String HoraPartida
        //{
        //    get { return horaPartida; }
        //    set { horaPartida = value; }
        //}

        //public String HoraLlegada
        //{
        //    get { return horaLlegada; }
        //    set { horaLlegada = value; }
        //}

        //public double Precio
        //{
        //    get { return precio; }
        //    set { precio = value; }
        //}

    } // Fin public class Vuelo

} // Fin namespace LogicaNegocios