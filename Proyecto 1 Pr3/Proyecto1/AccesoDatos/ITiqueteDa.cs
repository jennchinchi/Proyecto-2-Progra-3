
/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo tiquete
//----Encargado: -Jenniffer Chinchilla Porras
//---- Llave cambio = *creaticket

//----Fecha creación: 16-08-2015
//----Descripción: Inclusion de nuevos métodos, eliminarTiquetePrueba, 
//----buscarTiquetePrueba para pruebas unitarias
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *unittest
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
        //*creaticket
        string guardarTiquete(Tiquete tiquete);
        //*creaticket
        string modificarTiquete(Tiquete tiquete);
        //*creaticket
        List<Tiquete>listarTiquetes();
        //*creaticket
        Tiquete buscarporId(int idTiquete);
        //*creaticket
        List<Tiquete> buscarporClienteVuelo(string idCliente,int idVuelo);
        //*unittest
        void eliminarTiquetePrueba();
        //*unittest
        Tiquete buscarTiquetePrueba();
    }
}
