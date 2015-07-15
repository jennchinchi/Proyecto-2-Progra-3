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
    public class ClienteRegular : Cliente
    {
        public override double calcularPrecio(double precio,int moneda)
        {
            MillasAGanar = 0;
            return precio;
           
        }
        public override double Descuento
        {
            get { return descuento; }
            set { descuento = 0; }
        }
    }
}
