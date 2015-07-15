/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo cliente
//----Encargado: Roberto Mora Castro
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
    public abstract class Cliente
    {
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

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido 
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }
        public int Millas
        {
            get { return millas; }
            set { millas = value; }
        }

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
                return  (nombre + " " + apellido);
            }
        }
       
        public abstract double calcularPrecio(double precio,int moneda);

    }
}
