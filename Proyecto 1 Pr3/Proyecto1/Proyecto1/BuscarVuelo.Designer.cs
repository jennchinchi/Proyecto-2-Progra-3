namespace Presentacion
{
    partial class BuscarVuelo
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
            this.cboPlanes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listVuelos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.bindingAviones = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboSalida = new System.Windows.Forms.ComboBox();
            this.cmboDestino = new System.Windows.Forms.ComboBox();
            this.bindingSalida = new System.Windows.Forms.BindingSource(this.components);
            this.bindingDestino = new System.Windows.Forms.BindingSource(this.components);
            this.btnTrayectoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPlanes
            // 
            this.cboPlanes.FormattingEnabled = true;
            this.cboPlanes.Location = new System.Drawing.Point(545, 303);
            this.cboPlanes.Name = "cboPlanes";
            this.cboPlanes.Size = new System.Drawing.Size(144, 21);
            this.cboPlanes.TabIndex = 109;
            this.cboPlanes.SelectedIndexChanged += new System.EventHandler(this.cboPlanes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(460, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 108;
            this.label3.Text = "FLIGHT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(405, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "RETURN TIME:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtHoraLlegada
            // 
            this.dtHoraLlegada.Location = new System.Drawing.Point(544, 220);
            this.dtHoraLlegada.Name = "dtHoraLlegada";
            this.dtHoraLlegada.Size = new System.Drawing.Size(223, 20);
            this.dtHoraLlegada.TabIndex = 106;
            this.dtHoraLlegada.ValueChanged += new System.EventHandler(this.dtHoraLlegada_ValueChanged);
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.Location = new System.Drawing.Point(544, 188);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Size = new System.Drawing.Size(223, 20);
            this.dtHoraSalida.TabIndex = 105;
            this.dtHoraSalida.ValueChanged += new System.EventHandler(this.dtHoraSalida_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(373, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "DEPARTURE TIME:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(447, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 103;
            this.label6.Text = "DESTINY:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(459, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 102;
            this.label5.Text = "ORIGIN:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Presentacion.Properties.Resources.MODIFY;
            this.btnAgregar.Location = new System.Drawing.Point(545, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 28);
            this.btnAgregar.TabIndex = 112;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listVuelos
            // 
            this.listVuelos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listVuelos.BackColor = System.Drawing.SystemColors.Control;
            this.listVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.origen,
            this.destino});
            this.listVuelos.FullRowSelect = true;
            this.listVuelos.HideSelection = false;
            this.listVuelos.Location = new System.Drawing.Point(13, 188);
            this.listVuelos.MultiSelect = false;
            this.listVuelos.Name = "listVuelos";
            this.listVuelos.Size = new System.Drawing.Size(323, 188);
            this.listVuelos.TabIndex = 113;
            this.listVuelos.UseCompatibleStateImageBehavior = false;
            this.listVuelos.View = System.Windows.Forms.View.Details;
            this.listVuelos.SelectedIndexChanged += new System.EventHandler(this.listVuelos_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // origen
            // 
            this.origen.Text = "ORIGIN";
            this.origen.Width = 117;
            // 
            // destino
            // 
            this.destino.Text = "DESTINY";
            this.destino.Width = 198;
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(15, 161);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(55, 20);
            this.txtBId.TabIndex = 115;
            this.txtBId.TextChanged += new System.EventHandler(this.txtBId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBDestino
            // 
            this.txtBDestino.Location = new System.Drawing.Point(101, 161);
            this.txtBDestino.Name = "txtBDestino";
            this.txtBDestino.Size = new System.Drawing.Size(126, 20);
            this.txtBDestino.TabIndex = 117;
            this.txtBDestino.TextChanged += new System.EventHandler(this.txtBDestino_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(98, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 116;
            this.label7.Text = "DESTINY:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.BOTONES_01;
            this.btnBuscar.Location = new System.Drawing.Point(233, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 28);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // bindingAviones
            // 
            this.bindingAviones.CurrentChanged += new System.EventHandler(this.bindingVuelos_CurrentChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(545, 158);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(223, 20);
            this.txtPrecio.TabIndex = 120;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(469, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 119;
            this.label8.Text = "PRICE:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmboSalida
            // 
            this.cmboSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSalida.FormattingEnabled = true;
            this.cmboSalida.Location = new System.Drawing.Point(545, 246);
            this.cmboSalida.Name = "cmboSalida";
            this.cmboSalida.Size = new System.Drawing.Size(221, 21);
            this.cmboSalida.TabIndex = 124;
            // 
            // cmboDestino
            // 
            this.cmboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboDestino.FormattingEnabled = true;
            this.cmboDestino.Location = new System.Drawing.Point(545, 274);
            this.cmboDestino.Name = "cmboDestino";
            this.cmboDestino.Size = new System.Drawing.Size(221, 21);
            this.cmboDestino.TabIndex = 125;
            // 
            // btnTrayectoria
            // 
            this.btnTrayectoria.Location = new System.Drawing.Point(695, 303);
            this.btnTrayectoria.Name = "btnTrayectoria";
            this.btnTrayectoria.Size = new System.Drawing.Size(75, 23);
            this.btnTrayectoria.TabIndex = 126;
            this.btnTrayectoria.Text = "PATH";
            this.btnTrayectoria.UseVisualStyleBackColor = true;
            this.btnTrayectoria.Click += new System.EventHandler(this.btnTrayectoria_Click);
            // 
            // BuscarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.proyecto_sitemas_search;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.btnTrayectoria);
            this.Controls.Add(this.cmboSalida);
            this.Controls.Add(this.cmboDestino);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBDestino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listVuelos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboPlanes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHoraLlegada);
            this.Controls.Add(this.dtHoraSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "BuscarVuelo";
            this.Text = "SEARCH FLIGHT";
            this.Load += new System.EventHandler(this.BuscarVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingAviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPlanes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHoraLlegada;
        private System.Windows.Forms.DateTimePicker dtHoraSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listVuelos;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource bindingAviones;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader origen;
        private System.Windows.Forms.ColumnHeader destino;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboSalida;
        private System.Windows.Forms.ComboBox cmboDestino;
        private System.Windows.Forms.BindingSource bindingSalida;
        private System.Windows.Forms.BindingSource bindingDestino;
        private System.Windows.Forms.Button btnTrayectoria;
    }
}