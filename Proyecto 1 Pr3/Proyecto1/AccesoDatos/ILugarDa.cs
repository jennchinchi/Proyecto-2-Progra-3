/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo de lugares
//----Encargado: -Jenniffer Chinchilla Porras

//----Fecha creación: 28-06-2014
//----Descripción: Inclusion de nuevo método, listarLugares para 
//----combobox en vuelo
//----Encargado: -Jenniffer Chinchilla Porras
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
    public interface ILugarDa
    {
        Lugar buscarLugarPorId(int id);
        List<Lugar> listarLugares();
    }
}
