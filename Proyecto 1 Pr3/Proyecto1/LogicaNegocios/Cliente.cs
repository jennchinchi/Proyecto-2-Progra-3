/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo cliente
//----Encargado: Roberto Mora Castro
/*------------------------------------------------------------
 * //----Fecha creación: 09-08-2015  
//----Descripción: Mapping clase cliente LINQtoSQL 
//----Encargado: Roberto Mora Castro
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LINQtoSQL_Client
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LogicaNegocios

{
    [Table(Name = "Client")]
    [InheritanceMapping(Code = "Regular", Type = typeof(ClienteRegular), IsDefault = true)]
    [InheritanceMapping(Code = "Platinum", Type = typeof(ClientePlatino))]
    [InheritanceMapping(Code = "Diamond", Type = typeof(ClienteDiamante))]
    public abstract class Cliente
    {
        #region Variables

        private string id;
        private string nombre;
        private string apellido;
        private string email;
        private string telefono;
        private string estado;
        private string tipoCliente;
        private int millas;
        private int millasAGanar;
        protected double descuento;
        public const double tipoCambio = 545.00;
        #endregion

        #region PropiedadesMapeadas
        //LINQtoSQL_Client
        [Column(IsPrimaryKey = true, Name = "id")]
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "name")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "lastname")]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "phone")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "clientState")]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "clientType", IsDiscriminator = true)]
        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }

        //LINQtoSQL_Client
        [Column(Name = "miles")]
        public int Millas
        {
            get { return millas; }
            set { millas = value; }
        }

        #endregion

        public int MillasAGanar
        {
            get { return millasAGanar; }
            set { millasAGanar = value; }
        }


        public abstract double Descuento
        {
            get;
            set;
        }

        public string cmbDisplay
        {
            get
            {
                return (nombre + " " + apellido);
            }
        }

        public abstract double calcularPrecio(double precio, int moneda);

    }
}
