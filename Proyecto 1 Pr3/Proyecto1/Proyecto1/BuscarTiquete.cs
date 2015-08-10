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
using LogicaNegocios;

namespace Presentacion
{
    public partial class BuscarTiquete : Form
    {
         List<Tiquete> lt;
        Tiquete selectedT;
        Cliente selectedC;
        Vuelo selectedV;
        //*capadatos
        public BuscarTiquete()
        {
            InitializeComponent();
            cmbEstado.Items.Add("Active");
            cmbEstado.Items.Add("Inactive");
            cmbEstado.SelectedIndex = 0;
        }
        //*capadatos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idCliente = txtIdCliente.Text;
            string idVuelo = txtIdVuelo.Text;
            lt = Gestor.buscarTiquetesPorClienteOVuelo(idCliente, idVuelo);
            listTiquetes.Items.Clear();
            foreach (Tiquete t in lt)
            {
                ListViewItem li = new ListViewItem(t.IdTiquete.ToString());
                li.SubItems.Add(t.IdCliente.ToString());
                li.SubItems.Add(t.IdVuelo.ToString());
                listTiquetes.Items.Add(li);
            }
        }
        //*capadatos
        private void BuscarTiquete_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(1, "Dolars");
            comboSource.Add(2, "Colones");
            cmbMoneda.DataSource = new BindingSource(comboSource, null);
            cmbMoneda.DisplayMember = "Value";
            cmbMoneda.ValueMember = "Key";
            bindingTiquetes.DataSource = Gestor.listarClientes();
            cmbCliente.DataSource = bindingTiquetes.DataSource;
            cmbCliente.DisplayMember = "cmbDisplay";
            cmbCliente.ValueMember = "id";

            bindingTiquetes2.DataSource = Gestor.listarVuelos();
            cmbVuelo.DataSource = bindingTiquetes2.DataSource;
            cmbVuelo.DisplayMember = "cmbDisplay";
            cmbVuelo.ValueMember = "idVuelo";
        }
        //*capadatos
        private void listTiquetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listTiquetes.SelectedItems;
            if (selectedItems.Count > 0)
            {
                selectedT = lt.ElementAt(selectedItems[0].Index);
                cmbCliente.SelectedValue = selectedT.IdCliente;
                cmbVuelo.SelectedValue = selectedT.IdVuelo;
                cmbMoneda.SelectedValue = selectedT.Moneda;
                cmbEstado.Text = selectedT.Estado;
                cmbVuelo_SelectedIndexChanged(null, null);
            }
        }
        //*capadatos
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedC = (Cliente)cmbCliente.SelectedItem;
            lblTotal.Text = "";
            actualizarDetalle();
        }
        //*capadatos
        private void cmbVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedT != null)
            {
                selectedV = (Vuelo)cmbVuelo.SelectedItem;
                Avion av = Gestor.buscarAvionPorId(selectedV.IdAvion);
                List<int> asientosR = Gestor.listaAsientosReservados(selectedV.IdVuelo);
                List<int> asientosD = new List<int>();
                for (int i = 1; i <= av.Asientos; i++)
                {
                    if (asientosR.IndexOf(i) == -1 || i == selectedT.Asiento)
                    {
                        asientosD.Add(i);
                    }
                }
                bindingAsientos.DataSource = asientosD;
                cmbAsiento.DataSource = bindingAsientos.DataSource;
                cmbAsiento.Text = selectedT.Asiento.ToString();
                actualizarDetalle();
            }
        }
        //*capadatos
        private void actualizarDetalle()
        {
            if (selectedC != null)
            {
                lbltCliente.Text = selectedC.TipoCliente;
                selectedC.Descuento = 0;
                lbldescuento.Text = (selectedC.Descuento * 100).ToString() + "%";
            }
            if (selectedV != null)
            {
                lblPrecio.Text = selectedV.Precio.ToString();
                if (selectedC != null)
                {
                    lblTotal.Text = selectedC.calcularPrecio(selectedV.Precio, (int)cmbMoneda.SelectedValue).ToString();
                }
            }

        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarDetalle();
        }
        //*capadatos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            selectedT.Estado = cmbEstado.Text;
            selectedT.IdCliente = cmbCliente.SelectedValue.ToString();
            selectedT.IdVuelo = (int)cmbVuelo.SelectedValue;
            selectedT.Moneda = (int)cmbMoneda.SelectedValue;
            selectedT.Asiento = (int)cmbAsiento.SelectedValue;
            string resultado = Gestor.modificarTiquete(selectedT);
            if (resultado.Equals("True"))
            {
                MessageBox.Show("TICKET UPDATED", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(null, null);
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAsiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lbltCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lbldescuento_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
