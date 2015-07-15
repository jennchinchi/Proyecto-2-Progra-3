/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelos
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
    public interface IVueloDa
    {
        string guardarVuelo(Vuelo vuelo);
        string modificarVuelo(Vuelo vuelo);

        List<Vuelo> listarVuelos();
        Vuelo buscarporId(int idVuelo);

        List<Vuelo> buscarVuelosPorIdoDestino(int idVuelo, string destino);

        List<int> listaAsientosReservados(int idVuelo);

    }
}
