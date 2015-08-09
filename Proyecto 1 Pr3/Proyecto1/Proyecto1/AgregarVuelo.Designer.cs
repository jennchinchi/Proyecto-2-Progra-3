namespace Presentacion
{
    partial class AgregarVuelo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingAviones = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboDestino = new System.Windows.Forms.ComboBox();
            this.cmboSalida = new System.Windows.Forms.ComboBox();
            this.bindingSalida = new System.Windows.Forms.BindingSource(this.components);
            this.bindingDestino = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingAviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPlanes
            // 
            this.cboPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanes.FormattingEnabled = true;
            this.cboPlanes.Location = new System.Drawing.Point(167, 301);
            this.cboPlanes.Name = "cboPlanes";
            this.cboPlanes.Size = new System.Drawing.Size(144, 21);
            this.cboPlanes.TabIndex = 99;
            this.cboPlanes.SelectedIndexChanged += new System.EventHandler(this.cboPlanes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(90, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 98;
            this.label3.Text = "FLIGHT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "RETURN DATE:";
            // 
            // dtHoraLlegada
            // 
            this.dtHoraLlegada.Location = new System.Drawing.Point(167, 218);
            this.dtHoraLlegada.Name = "dtHoraLlegada";
            this.dtHoraLlegada.Size = new System.Drawing.Size(223, 20);
            this.dtHoraLlegada.TabIndex = 92;
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.Location = new System.Drawing.Point(167, 186);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Size = new System.Drawing.Size(223, 20);
            this.dtHoraSalida.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(-2, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "DEPARTURE DATE:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Presentacion.Properties.Resources.sdsdc_02;
            this.btnAgregar.Location = new System.Drawing.Point(148, 340);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 28);
            this.btnAgregar.TabIndex = 89;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.AgregarVuelo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(78, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "DESTINY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(90, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "ORIGIN:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(166, 157);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(223, 20);
            this.txtPrecio.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(96, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 121;
            this.label4.Text = "PRICE:";
            // 
            // cmboDestino
            // 
            this.cmboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboDestino.FormattingEnabled = true;
            this.cmboDestino.Location = new System.Drawing.Point(168, 271);
            this.cmboDestino.Name = "cmboDestino";
            this.cmboDestino.Size = new System.Drawing.Size(221, 21);
            this.cmboDestino.TabIndex = 123;
            // 
            // cmboSalida
            // 
            this.cmboSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSalida.FormattingEnabled = true;
            this.cmboSalida.Location = new System.Drawing.Point(168, 243);
            this.cmboSalida.Name = "cmboSalida";
            this.cmboSalida.Size = new System.Drawing.Size(221, 21);
            this.cmboSalida.TabIndex = 123;
            // 
            // AgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.proyecto_sitemas_flights;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.cmboSalida);
            this.Controls.Add(this.cmboDestino);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPlanes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHoraLlegada);
            this.Controls.Add(this.dtHoraSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "AgregarVuelo";
            this.Text = "ADD FLIGHT";
            this.Load += new System.EventHandler(this.AgregarVuelo_Load);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingAviones;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboDestino;
        private System.Windows.Forms.ComboBox cmboSalida;
        private System.Windows.Forms.BindingSource bindingSalida;
        private System.Windows.Forms.BindingSource bindingDestino;
    }
}

