namespace Presentacion
{
    partial class AgregarTiquete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVuelo = new System.Windows.Forms.ComboBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.bindingClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingVuelos = new System.Windows.Forms.BindingSource(this.components);
            this.lbltCliente = new System.Windows.Forms.Label();
            this.cmbAsiento = new System.Windows.Forms.ComboBox();
            this.bindingAsientos = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Presentacion.Properties.Resources.sdsdc_02;
            this.btnAgregar.Location = new System.Drawing.Point(590, 359);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 28);
            this.btnAgregar.TabIndex = 90;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(227, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 97;
            this.label5.Text = "ASIENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 93;
            this.label3.Text = "CLIENTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "MONEDA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 91;
            this.label1.Text = "VUELO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(574, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 99;
            this.label4.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(574, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 100;
            this.label6.Text = "DESCUENTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(574, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 101;
            this.label7.Text = "TOTAL A PAGAR:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(657, 245);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(18, 19);
            this.lblPrecio.TabIndex = 102;
            this.lblPrecio.Text = "0";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.BackColor = System.Drawing.Color.Transparent;
            this.lbldescuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.ForeColor = System.Drawing.Color.White;
            this.lbldescuento.Location = new System.Drawing.Point(698, 282);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(18, 19);
            this.lbldescuento.TabIndex = 103;
            this.lbldescuento.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(720, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 19);
            this.lblTotal.TabIndex = 104;
            this.lblTotal.Text = "0";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(317, 215);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(230, 21);
            this.cmbCliente.TabIndex = 105;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // cmbVuelo
            // 
            this.cmbVuelo.FormattingEnabled = true;
            this.cmbVuelo.Location = new System.Drawing.Point(317, 248);
            this.cmbVuelo.Name = "cmbVuelo";
            this.cmbVuelo.Size = new System.Drawing.Size(230, 21);
            this.cmbVuelo.TabIndex = 106;
            this.cmbVuelo.SelectedIndexChanged += new System.EventHandler(this.cmbVuelo_SelectedIndexChanged);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(317, 275);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(120, 21);
            this.cmbMoneda.TabIndex = 107;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // lbltCliente
            // 
            this.lbltCliente.AutoSize = true;
            this.lbltCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbltCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltCliente.ForeColor = System.Drawing.Color.White;
            this.lbltCliente.Location = new System.Drawing.Point(574, 215);
            this.lbltCliente.Name = "lbltCliente";
            this.lbltCliente.Size = new System.Drawing.Size(120, 19);
            this.lbltCliente.TabIndex = 108;
            this.lbltCliente.Text = "TIPO CLIENTE";
            // 
            // cmbAsiento
            // 
            this.cmbAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsiento.FormattingEnabled = true;
            this.cmbAsiento.Location = new System.Drawing.Point(316, 306);
            this.cmbAsiento.Name = "cmbAsiento";
            this.cmbAsiento.Size = new System.Drawing.Size(121, 21);
            this.cmbAsiento.TabIndex = 109;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(316, 342);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 111;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(227, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 110;
            this.label8.Text = "ESTADO:";
            // 
            // AgregarTiquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.proyecto_sitemas_tickets;
            this.ClientSize = new System.Drawing.Size(801, 411);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAsiento);
            this.Controls.Add(this.lbltCliente);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.cmbVuelo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "AgregarTiquete";
            this.Text = "AgregarTiquete";
            this.Load += new System.EventHandler(this.AgregarTiquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVuelo;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.BindingSource bindingClientes;
        private System.Windows.Forms.BindingSource bindingVuelos;
        private System.Windows.Forms.Label lbltCliente;
        private System.Windows.Forms.ComboBox cmbAsiento;
        private System.Windows.Forms.BindingSource bindingAsientos;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label8;
    }
}