/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo tiquete
//----Encargado: -Jenniffer Chinchilla Porras
//
//----Fecha: 07-08-2015
//----Descripción: Se incluyen cambios en clase para hacer consultas con linq
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave= camblinqticket
/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//camblinqticket
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LogicaNegocios
{
    //camblinqticket
    [Table(Name = "Ticket")]
    public class Tiquete
    {
        private int idTiquete;
        private int moneda;
        private String estado;
        private String idCliente;
        private int idVuelo;
        private int asiento;
        //camblinqticket
        [Column(Name = "idTicket", IsPrimaryKey = true, DbType = "int NOT NULL", IsDbGenerated = true)]
        public int IdTiquete
        {
            get { return idTiquete; }
            set { idTiquete = value; }
        }
        //camblinqticket
        [Column(Name = "currency")]
        public int Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }
        //camblinqticket
        [Column(Name = "ticketState")]
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        //camblinqticket
        [Column(Name = "idClient")]
        public String IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        //camblinqticket
        [Column(Name = "idFlight")]
        public int IdVuelo
        {
            get { return idVuelo; }
            set { idVuelo = value; }
        }
        //camblinqticket
        [Column(Name = "numSeat")]
        public int Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

    }
}
