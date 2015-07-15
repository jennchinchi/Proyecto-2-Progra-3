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
using LogicaNegocios;

namespace Presentacion
{
    public partial class BuscarTiquete : Form
    {
         List<Tiquete> lt;
        Tiquete selectedT;
        Cliente selectedC;
        Vuelo selectedV;
        public BuscarTiquete()
        {
            InitializeComponent();
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Pago");
            cmbEstado.SelectedIndex = 0;
        }

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

        private void BuscarTiquete_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            comboSource.Add(1, "Dolares");
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

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedC = (Cliente)cmbCliente.SelectedItem;
            lblTotal.Text = "";
            actualizarDetalle();
        }

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
                MessageBox.Show("TIQUETE ACTUALIZADO SATISFACTORIAMENTE", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(null, null);
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
