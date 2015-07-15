/*------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------*/
//----Fecha creación: 06-07-2015 
//----Descripción: Creación de pantalla para trayectoria con googlemaps
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
    public partial class Trayectoria : Form
    {

        private string latitud_o,longitud_o,latitud_d,longitud_d;

        public Trayectoria()
        {
            InitializeComponent();
        }

        private void Trayectoria_Load(object sender, EventArgs e)
        {
            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("https://www.google.co.cr/maps/dir/" + latitud_o + "," + longitud_o + "/" + latitud_d + "," + longitud_d);
            webBrowser.Navigate(queryAddress.ToString());
        }

        public void cambiarCoordenadas(string lat_o, string long_o, string lat_d, string long_d)
        {
            latitud_o = lat_o;
            longitud_o = long_o;
            latitud_d = lat_d;
            longitud_d = long_d;
        }
    }
}
