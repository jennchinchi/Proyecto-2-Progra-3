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
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LogicaNegocios
{
    [Table(Name = "Ticket")]
    public class Tiquete
    {
        private int idTiquete;
        private int moneda;
        private String estado;
        private String idCliente;
        private int idVuelo;
        private int asiento;

        [Column(Name = "idTicket", IsPrimaryKey = true, DbType = "int NOT NULL", IsDbGenerated = true)]
        public int IdTiquete
        {
            get { return idTiquete; }
            set { idTiquete = value; }
        }
        [Column(Name = "currency")]
        public int Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }
        [Column(Name = "ticketState")]
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        [Column(Name = "idClient")]
        public String IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        [Column(Name = "idFlight")]
        public int IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }
        [Column(Name = "numSeat")]
        public int Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

    }
}
