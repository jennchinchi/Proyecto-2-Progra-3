/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 14-06-2015 
//----Descripción: Creación diseño módulo
//----Encargado: Dennis Hurtado Prada

//----Fecha creación: 28-06-2015 / 05-07-2015
//----Descripción: Modificacion de diseño para implementacion con 
//---- capa de datos 
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
    public partial class AgregarVuelo : Form
    {
        public AgregarVuelo()
        {
            InitializeComponent();
        }

        private void AgregarVuelo_Load(object sender, EventArgs e)
        {
            bindingAviones.DataSource = Gestor.listarAviones();

            cboPlanes.DataSource = bindingAviones.DataSource;
            cboPlanes.DisplayMember = "marca";
            cboPlanes.ValueMember = "idAvion";

            bindingSalida.DataSource = Gestor.listarLugares();

            cmboSalida.DataSource = bindingSalida.DataSource;
            cmboSalida.DisplayMember = "nombre";
            cmboSalida.ValueMember = "idLugar";

            bindingDestino.DataSource = Gestor.listarLugares();
            cmboDestino.DataSource = bindingDestino.DataSource;
            cmboDestino.DisplayMember = "nombre";
            cmboDestino.ValueMember = "idLugar";
        }

        private void AgregarVuelo_Click(object sender, EventArgs e)
        {
            int idAvion = (int)cboPlanes.SelectedValue;
            string origen = cmboSalida.SelectedValue.ToString(),
                destino = cmboDestino.SelectedValue.ToString(), 
                horaPartida = dtHoraSalida.Text,
                horaLlegada = dtHoraLlegada.Text,
                precio = txtPrecio.Text;
            string resultado = Gestor.agregarVuelo(idAvion, origen, destino, horaPartida, horaLlegada, precio);
            if(resultado.Equals("True"))
            {
                MessageBox.Show("VUELO REGISTRADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
