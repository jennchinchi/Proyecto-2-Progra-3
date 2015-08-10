/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelos
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *creavuelo
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
    public interface IVueloDa
    {
        //*creavuelo
        string guardarVuelo(Vuelo vuelo);
        //*creavuelo
        string modificarVuelo(Vuelo vuelo);
        //*creavuelo
        List<Vuelo> listarVuelos();
        //*creavuelo
        Vuelo buscarporId(int idVuelo);
        //*creavuelo
        List<Vuelo> buscarVuelosPorIdoDestino(int idVuelo, string destino);
        //*creavuelo
        List<int> listaAsientosReservados(int idVuelo);

    }
}
