/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo avion
//----Encargado: -Dennis Hurtado Prada

//----Fecha modificacion: 11-07-2015 / 01-07-2015
//----Descripción: linq to sql
//----Encargado: -Dennis Hurtado Prada
/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace LogicaNegocios
{
    [Table(Name = "Plane")]
    public class Avion
    {
        private int idAvion;
        private int asientos;
        private String marca;

        [Column(Name = "idPlane", IsPrimaryKey = true, DbType = "int NOT NULL", IsDbGenerated = true)]
        public int IdAvion
        {
            get { return idAvion; }
            set { idAvion = value; }
        }

        [Column(Name = "qtyAsiento")]
        public int Asientos
        {
            get { return asientos; }
            set { asientos = value; }
        }

        [Column(Name = "marca")]
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
    }
}
