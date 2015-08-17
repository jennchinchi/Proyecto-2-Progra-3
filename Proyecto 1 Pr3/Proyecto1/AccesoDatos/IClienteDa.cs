/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 / 01-07-2015
//----Descripción: Creación estructura módulo cliente
//----Encargado: Roberto Mora Castro
//---Llave cambio = *creacliente

//----Fecha creación: 27-06-2014
//----Descripción: Inclusion de nuevos métodos, listarClientesPorIDoNombre
//----para busquedas en el listview
//----Encargado: -Jenniffer Chinchilla Porras
//---- Llave cambio = *listview

//----Fecha creación: 16-08-2015
//----Descripción: Inclusion de nuevos métodos, eliminarClientePrueba, 
//----buscarClientePrueba para pruebas unitarias
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
    public interface IClienteDa
    {
        // *creacliente
        string guardarCliente(Cliente cliente);
        // *creacliente
        string modificarCliente(Cliente cliente);
        // *creacliente
        List<Cliente> listarClientes();
        // *creacliente
        Cliente buscarporId(int idCliente);
        // *listview
        List<Cliente> listarClientesPorIdONombre(string id, string nombre);
        //*unittest
        void eliminarClientePrueba();
        //*unittest
        Cliente buscarClientePrueba();
    }
}
