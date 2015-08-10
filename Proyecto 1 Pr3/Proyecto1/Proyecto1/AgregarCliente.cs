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
//----Llave cambio = *capadatos
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
    //*capadatos
    public partial class AgregarCliente : Form
    {
        //*capadatos
        public AgregarCliente()
        {
            InitializeComponent();
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbType.Items.Add("Regular");
            cmbType.Items.Add("Platinum");
            cmbType.Items.Add("Diamond");
            cmbType.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
        }
        //*capadatos
        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text,
            nombre = txtName.Text,
            apellido = txtLastName.Text,
            email = txtEmail.Text,
            telefono = txtPhone.Text,
            estado = cmbState.Text,
            tipo = cmbType.Text;
            int millas;
            if (txtMillas.Text == "")
            {
                millas = 0;
            }
            else
            {
                millas = int.Parse(txtMillas.Text);
            }


            string resultado = Gestor.agregarCliente(id, nombre, apellido, email, telefono, estado, tipo, millas);
            if (resultado.Equals("True"))
            {
                MessageBox.Show("CLIENT ADDED", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }
        //*capadatos
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("NUMBERS ONLY", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        //*capadatos
        private void txtName_KeyPress(object sender, KeyPressEventArgs e) //validacion solo letras
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("LETTERS ONLY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }
        //*capadatos
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("LETTERS ONLY", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }
    }
}
