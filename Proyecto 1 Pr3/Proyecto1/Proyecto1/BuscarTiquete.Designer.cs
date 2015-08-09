namespace Presentacion
{
    partial class BuscarTiquete
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
            this.listTiquetes = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdVuelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdVuelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAsiento = new System.Windows.Forms.ComboBox();
            this.lbltCliente = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.cmbVuelo = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.bindingTiquetes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingTiquetes2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.bindingClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingVuelos = new System.Windows.Forms.BindingSource(this.components);
            this.bindingAsientos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingTiquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTiquetes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingVuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // listTiquetes
            // 
            this.listTiquetes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnIdCliente,
            this.columnIdVuelo});
            this.listTiquetes.FullRowSelect = true;
            this.listTiquetes.GridLines = true;
            this.listTiquetes.HideSelection = false;
            this.listTiquetes.Location = new System.Drawing.Point(8, 185);
            this.listTiquetes.Name = "listTiquetes";
            this.listTiquetes.Size = new System.Drawing.Size(326, 206);
            this.listTiquetes.TabIndex = 0;
            this.listTiquetes.UseCompatibleStateImageBehavior = false;
            this.listTiquetes.View = System.Windows.Forms.View.Details;
            this.listTiquetes.SelectedIndexChanged += new System.EventHandler(this.listTiquetes_SelectedIndexChanged);
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 78;
            // 
            // columnIdCliente
            // 
            this.columnIdCliente.Text = "CLIENT\'S ID";
            this.columnIdCliente.Width = 146;
            // 
            // columnIdVuelo
            // 
            this.columnIdVuelo.Text = "FLIGHT\'S ID";
            this.columnIdVuelo.Width = 165;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.BOTONES_01;
            this.btnBuscar.Location = new System.Drawing.Point(230, 155);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 28);
            this.btnBuscar.TabIndex = 142;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdVuelo
            // 
            this.txtIdVuelo.Location = new System.Drawing.Point(98, 159);
            this.txtIdVuelo.Name = "txtIdVuelo";
            this.txtIdVuelo.Size = new System.Drawing.Size(126, 20);
            this.txtIdVuelo.TabIndex = 141;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(95, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 140;
            this.label7.Text = "FLIGHT\'S ID:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(12, 159);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(80, 20);
            this.txtIdCliente.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 138;
            this.label4.Text = "CLIENT\'S ID:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(434, 304);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 160;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(372, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 159;
            this.label8.Text = "STATE:";
            // 
            // cmbAsiento
            // 
            this.cmbAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsiento.FormattingEnabled = true;
            this.cmbAsiento.Location = new System.Drawing.Point(434, 268);
            this.cmbAsiento.Name = "cmbAsiento";
            this.cmbAsiento.Size = new System.Drawing.Size(121, 21);
            this.cmbAsiento.TabIndex = 158;
            this.cmbAsiento.SelectedIndexChanged += new System.EventHandler(this.cmbAsiento_SelectedIndexChanged);
            // 
            // lbltCliente
            // 
            this.lbltCliente.AutoSize = true;
            this.lbltCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbltCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltCliente.ForeColor = System.Drawing.Color.White;
            this.lbltCliente.Location = new System.Drawing.Point(671, 177);
            this.lbltCliente.Name = "lbltCliente";
            this.lbltCliente.Size = new System.Drawing.Size(129, 19);
            this.lbltCliente.TabIndex = 157;
            this.lbltCliente.Text = "CLIENT\'S TYPE";
            this.lbltCliente.Click += new System.EventHandler(this.lbltCliente_Click);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(435, 237);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(120, 21);
            this.cmbMoneda.TabIndex = 156;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // cmbVuelo
            // 
            this.cmbVuelo.FormattingEnabled = true;
            this.cmbVuelo.Location = new System.Drawing.Point(435, 210);
            this.cmbVuelo.Name = "cmbVuelo";
            this.cmbVuelo.Size = new System.Drawing.Size(230, 21);
            this.cmbVuelo.TabIndex = 155;
            this.cmbVuelo.SelectedIndexChanged += new System.EventHandler(this.cmbVuelo_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(718, 311);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 19);
            this.lblTotal.TabIndex = 153;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.BackColor = System.Drawing.Color.Transparent;
            this.lbldescuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.ForeColor = System.Drawing.Color.White;
            this.lbldescuento.Location = new System.Drawing.Point(718, 276);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(18, 19);
            this.lbldescuento.TabIndex = 152;
            this.lbldescuento.Text = "0";
            this.lbldescuento.Click += new System.EventHandler(this.lbldescuento_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(718, 239);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(18, 19);
            this.lblPrecio.TabIndex = 151;
            this.lblPrecio.Text = "0";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 150;
            this.label1.Text = "TOTAL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(598, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 149;
            this.label6.Text = "DISCOUNT:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(598, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 148;
            this.label2.Text = "PRICE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(384, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 147;
            this.label5.Text = "SEAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 146;
            this.label3.Text = "CLIENT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(333, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 145;
            this.label9.Text = "CURRENCY:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(369, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 144;
            this.label10.Text = "FLIGHT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(718, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 148;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(718, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 19);
            this.label13.TabIndex = 150;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(736, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 19);
            this.label17.TabIndex = 157;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Presentacion.Properties.Resources.MODIFY;
            this.btnModificar.Location = new System.Drawing.Point(491, 363);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 28);
            this.btnModificar.TabIndex = 161;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(435, 178);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(230, 21);
            this.cmbCliente.TabIndex = 162;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // BuscarTiquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.proyecto_sitemas_search;
            this.ClientSize = new System.Drawing.Size(804, 412);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAsiento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbltCliente);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.cmbVuelo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdVuelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTiquetes);
            this.Name = "BuscarTiquete";
            this.Text = "SEARCH TICKET";
            this.Load += new System.EventHandler(this.BuscarTiquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingTiquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTiquetes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingVuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listTiquetes;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnIdCliente;
        private System.Windows.Forms.ColumnHeader columnIdVuelo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdVuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAsiento;
        private System.Windows.Forms.Label lbltCliente;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.ComboBox cmbVuelo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.BindingSource bindingTiquetes;
        private System.Windows.Forms.BindingSource bindingTiquetes2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.BindingSource bindingClientes;
        private System.Windows.Forms.BindingSource bindingVuelos;
        private System.Windows.Forms.BindingSource bindingAsientos;
    }
}