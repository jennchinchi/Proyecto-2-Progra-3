
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
using LogicaNegocios;

namespace AccesoDatos
{
    public interface ITiqueteDa
    {

        string guardarTiquete(Tiquete tiquete);
        string modificarTiquete(Tiquete tiquete);
        
        List<Tiquete>listarTiquetes();
        Tiquete buscarporId(int idTiquete);
        List<Tiquete> buscarporClienteVuelo(string idCliente,int idVuelo);


    }
}
