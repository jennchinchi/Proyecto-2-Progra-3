/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 28-06-2015 / 05-07-2015
//----Descripción: Creacion de pantalla menu 
//----Encargado: Jenniffer Chinchilla Porras
/*--------------------------------------------------------------
---------------FIN HISTORIAL DE MODIFICACION ---------------
------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        AgregarCliente ac;
        AgregarVuelo av;
        AgregarTiquete at;
        BuscarCliente bc;
        BuscarVuelo bv;
        BuscarTiquete bt;
        public Principal()
        {
            InitializeComponent();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ac = new AgregarCliente();
            ac.Show();
        }

        private void agregarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            av = new AgregarVuelo();
            av.Show();
        }

        private void comprarTiqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            at = new AgregarTiquete();
            at.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bc = new BuscarCliente();
            bc.Show();
        }

        private void buscarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bv = new BuscarVuelo();
            bv.Show();
        }

        private void buscarTiqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt = new BuscarTiquete();
            bt.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
