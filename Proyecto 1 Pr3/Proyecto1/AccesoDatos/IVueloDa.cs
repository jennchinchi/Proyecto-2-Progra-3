/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo vuelos
//----Encargado: -Jenniffer Chinchilla Porras
//----Llave cambio = *creavuelo

//----Fecha creación: 16-08-2015
//----Descripción: Inclusion de nuevos métodos, eliminarVueloPrueba, 
//----buscarVueloPrueba para pruebas unitarias
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
        //*unittest
        void eliminarVueloPrueba();
        //*unittest
        Vuelo buscarVueloPrueba();
    }
}
