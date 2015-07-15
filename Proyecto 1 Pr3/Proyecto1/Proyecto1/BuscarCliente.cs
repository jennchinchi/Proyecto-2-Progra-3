/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 
//----Descripción: Creación diseño módulo
//----Encargado: Dennis Hurtado Prada

//----Fecha creación: 28-06-2015 / 05-07-2015
//----Descripción: Modificacion de diseño para implementacion con 
//---- capa de datos 
//----Encargado: Roberto Mora Castro

//----Fecha creación: 28-06-2015 / 05-07-2015
//----Descripción: Modificacion de diseño para implementacion del
//----ListView para observar lista de clientes activos/inactivos
//----ya sea por nombre, por id o todos 
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
using LogicaNegocios;

namespace Presentacion
{
    public partial class BuscarCliente : Form
    {

        List<Cliente> lc;
        Cliente selectedC;
        public BuscarCliente()
        {
            InitializeComponent();
            cmbTipo.Items.Add("Regular");
            cmbTipo.Items.Add("Platino");
            cmbTipo.Items.Add("Diamante");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtBId.Text;
            string nombre = txtBNombre.Text;
            lc = Gestor.buscarClientesPorIdONombre(id, nombre);
            listClientes.Items.Clear();
            foreach (Cliente c in lc)
            {
                ListViewItem li = new ListViewItem(c.Id.ToString());
                li.SubItems.Add(c.Nombre);
                li.SubItems.Add(c.TipoCliente);
                li.SubItems.Add(c.Email);
                listClientes.Items.Add(li);
            }
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listClientes.SelectedItems;
            if (selectedItems.Count > 0)
            {
                selectedC = lc.ElementAt(selectedItems[0].Index);
                txtId.Text = selectedC.Id;
                txtNombre.Text = selectedC.Nombre;
                txtApellido.Text = selectedC.Apellido;
                txtEmail.Text = selectedC.Email;
                txtTelefono.Text = selectedC.Telefono;
                cmbEstado.Text = selectedC.Estado;
                cmbTipo.Text = selectedC.TipoCliente;
                txtMillas.Text = selectedC.Millas.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            selectedC.Id = txtId.Text;
            selectedC.Nombre = txtNombre.Text;
            selectedC.Apellido = txtApellido.Text;
            selectedC.Email = txtEmail.Text;
            selectedC.Telefono = txtTelefono.Text;
            selectedC.Estado = cmbEstado.Text;
            selectedC.TipoCliente = cmbTipo.Text;
            selectedC.Millas = int.Parse(txtMillas.Text);
            string resultado = Gestor.modificarCliente(selectedC);
            if (resultado.Equals("True"))
            {
                MessageBox.Show("CLIENTE ACTUALIZADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(null, null);
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
