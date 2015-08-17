/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo avion
//----Encargado: -Dennis Hurtado Prada
//----Llave cambio = *creaavion

//----Fecha creación: 28-06-2014
//----Descripción: Inclusion de nuevo método, listarAviones para 
//----combobox en vuelo
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *comboavion

/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocios;

namespace AccesoDatos
{
    public interface IAvionDa
    {
        //*creaavion
        Avion buscarAvionPorId(int id);
        //*comboavion
        List<Avion> listarAviones();
    }
}
