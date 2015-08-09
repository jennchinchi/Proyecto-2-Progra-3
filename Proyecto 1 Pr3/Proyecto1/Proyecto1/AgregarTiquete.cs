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
    public partial class AgregarTiquete : Form
    {
        Cliente selectedC;
        Vuelo selectedV;
        public AgregarTiquete()
        {
            InitializeComponent();
            cmbEstado.Items.Add("Active");
            cmbEstado.Items.Add("Inactive");
            cmbEstado.SelectedIndex = 0;
        }
        private void AgregarTiquete_Load(object sender, EventArgs e)
        {
            Dictionary<int,string> comboSource = new Dictionary<int,string>();
            comboSource.Add(1, "Dolars");
            comboSource.Add(2, "Colones");
            cmbMoneda.DataSource = new BindingSource(comboSource, null);
            cmbMoneda.DisplayMember = "Value";
            cmbMoneda.ValueMember = "Key";
            bindingClientes.DataSource = Gestor.listarClientes();
            cmbCliente.DataSource = bindingClientes.DataSource;
            cmbCliente.DisplayMember = "cmbDisplay";
            cmbCliente.ValueMember = "id";

            bindingVuelos.DataSource = Gestor.listarVuelos();
            cmbVuelo.DataSource = bindingVuelos.DataSource;
            cmbVuelo.DisplayMember = "cmbDisplay";
            cmbVuelo.ValueMember = "idVuelo";

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedC = (Cliente)cmbCliente.SelectedItem;
            lblTotal.Text = "";
            actualizarDetalle();
        }

        private void cmbVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedV = (Vuelo)cmbVuelo.SelectedItem;
            Avion av = Gestor.buscarAvionPorId(selectedV.IdAvion);
            List<int> asientosR = Gestor.listaAsientosReservados(selectedV.IdVuelo);
            List<int> asientosD = new List<int>();
            for (int i = 1; i <= av.Asientos; i++ )
            {
                if(asientosR.IndexOf(i) == -1)
                {
                    asientosD.Add(i);
                }
            }
            bindingAsientos.DataSource = asientosD;
            cmbAsiento.DataSource = bindingAsientos.DataSource;
            actualizarDetalle();
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
                    lblTotal.Text = selectedC.calcularPrecio(selectedV.Precio,(int)cmbMoneda.SelectedValue).ToString();
                }
            }
            
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarDetalle();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String
            estado = cmbEstado.Text;
            int idVuelo = (int)cmbVuelo.SelectedValue,
            moneda = (int)cmbMoneda.SelectedValue,
            asiento = (int)cmbAsiento.SelectedValue;
            string resultado = Gestor.agregarTiquete(estado, selectedC, idVuelo, moneda, asiento);
            if (resultado.Equals("True"))
            {
                MessageBox.Show("TICKET ADDED", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   
    }
}

