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
//----Llave cambio =*capadatos

//----Fecha creación: 15-08-2015
//----Descripción: Agregar boton de cancelar 
//----Encargado: Ronald Moreira Artavia
//----Llave cambio = camb_Bt_Cancel

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
    public partial class BuscarVuelo : Form
    {
        List<Vuelo> lv;
        List<Lugar> lgsalida;
        List<Lugar> lgdestino;
        Vuelo selectedV;
        Trayectoria tr;
        public BuscarVuelo()
        {
            InitializeComponent();
        }
        //*capadatos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtBId.Text;
            string destino = txtBDestino.Text;
            lv = Gestor.buscarVuelosPorIdODestino(id, destino);
            listVuelos.Items.Clear();
            foreach (Vuelo v in lv)
            {
                ListViewItem li = new ListViewItem(v.IdVuelo.ToString());
                li.SubItems.Add(lgsalida.First(item => item.IdLugar == int.Parse(v.Origen)).Nombre);
                li.SubItems.Add(lgdestino.First(item => item.IdLugar == int.Parse(v.Destino)).Nombre);
                listVuelos.Items.Add(li);
            }
        }
        //*capadatos
        private void listVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = listVuelos.SelectedItems;
            if (selectedItems.Count > 0)
            {
                selectedV = lv.ElementAt(selectedItems[0].Index);
                cmboSalida.SelectedValue = int.Parse(selectedV.Origen);
                cmboDestino.SelectedValue = int.Parse(selectedV.Destino);
                dtHoraSalida.Value = DateTime.Parse(selectedV.HoraPartida);
                dtHoraLlegada.Value = DateTime.Parse(selectedV.HoraLlegada);
                txtPrecio.Text = selectedV.Precio.ToString();
                cboPlanes.SelectedValue = selectedV.IdAvion;
            }
        }
        //*capadatos
        private void BuscarVuelo_Load(object sender, EventArgs e)
        {
            bindingAviones.DataSource = Gestor.listarAviones();

            cboPlanes.DataSource = bindingAviones.DataSource;
            cboPlanes.DisplayMember = "marca";
            cboPlanes.ValueMember = "idAvion";

            lgsalida = Gestor.listarLugares();
            bindingSalida.DataSource = lgsalida;

            cmboSalida.DataSource = bindingSalida.DataSource;
            cmboSalida.DisplayMember = "nombre";
            cmboSalida.ValueMember = "idLugar";


            lgdestino = Gestor.listarLugares();
            bindingDestino.DataSource = lgdestino;

            cmboDestino.DataSource = bindingDestino.DataSource;
            cmboDestino.DisplayMember = "nombre";
            cmboDestino.ValueMember = "idLugar";
        }

        private void bindingVuelos_CurrentChanged(object sender, EventArgs e)
        {

        }

        // Boton modificar
        //*capadatos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            selectedV.Origen = cmboSalida.SelectedValue.ToString();
            selectedV.Destino = cmboDestino.SelectedValue.ToString();
            selectedV.HoraLlegada = dtHoraLlegada.Text;
            selectedV.HoraPartida = dtHoraSalida.Text;
            selectedV.IdAvion = (int)cboPlanes.SelectedValue;
            selectedV.Precio = double.Parse(txtPrecio.Text);
            string resultado = Gestor.modificarVuelo(selectedV);
            if (resultado.Equals("True"))
            {
                MessageBox.Show("FLIGHT ADDED", "UAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(null, null);
            }
            else
            {
                MessageBox.Show(resultado, "UAM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtHoraLlegada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtHoraSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtLlegada_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnTrayectoria_Click(object sender, EventArgs e)
        {         
            Lugar o = lgsalida.First(item => item.IdLugar == int.Parse(selectedV.Origen));
            Lugar d = lgdestino.First(item => item.IdLugar == int.Parse(selectedV.Destino));
            
            if (tr == null || tr.IsDisposed)
            {
                tr = new Trayectoria();
                tr.cambiarCoordenadas(o.Latitud, o.Longitud, d.Latitud, d.Longitud);
                tr.Show();
            }
            else
            {
                tr.cambiarCoordenadas(o.Latitud, o.Longitud, d.Latitud, d.Longitud);
                tr.Focus();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Cancel_Click(object sender, EventArgs e) //camb_Bt_Cancel
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Confirmación de salida.",
                                                         "Confirmación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    this.Close();
                } // Fin if
            } // Fin try

            catch
            {
                MessageBox.Show("ERROR: Hay un problema al cerrar pantalla, contacte al administrador.",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // Fin catch

        }
    }
}
