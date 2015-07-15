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
    public class ClientePlatino : Cliente
    {
        public override double calcularPrecio(double precio,int moneda)
        {
            int mil;
            double precioTotal;
            precioTotal = precio - (precio * descuento);
            if (moneda == 2) // colones
            {
                precioTotal *= tipoCambio;
            }
            mil = Millas / 10000;
            MillasAGanar = mil * 500;

            return precioTotal;
            
        }
        public override double Descuento
        {
            get
            {
                return descuento; }
            set { descuento = 0.05; }
        }

    }
}
