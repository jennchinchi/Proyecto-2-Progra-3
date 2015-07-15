namespace Presentacion
{
    partial class BuscarCliente
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
            this.bindingClientes = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listClientes = new System.Windows.Forms.ListView();
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMillas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Presentacion.Properties.Resources.BOTONES_01;
            this.btnBuscar.Location = new System.Drawing.Point(232, 155);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 28);
            this.btnBuscar.TabIndex = 137;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(100, 159);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(126, 20);
            this.txtBNombre.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(97, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 135;
            this.label7.Text = "NOMBRE:";
            // 
            // txtBId
            // 
            this.txtBId.Location = new System.Drawing.Point(14, 159);
            this.txtBId.Name = "txtBId";
            this.txtBId.Size = new System.Drawing.Size(80, 20);
            this.txtBId.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 133;
            this.label4.Text = "ID:";
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            this.tipo.Width = 71;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 83;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 58;
            // 
            // listClientes
            // 
            this.listClientes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listClientes.BackColor = System.Drawing.SystemColors.Control;
            this.listClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nombre,
            this.tipo,
            this.email});
            this.listClientes.FullRowSelect = true;
            this.listClientes.HideSelection = false;
            this.listClientes.Location = new System.Drawing.Point(12, 186);
            this.listClientes.MultiSelect = false;
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(323, 188);
            this.listClientes.TabIndex = 132;
            this.listClientes.UseCompatibleStateImageBehavior = false;
            this.listClientes.View = System.Windows.Forms.View.Details;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 104;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Presentacion.Properties.Resources.MODIFY;
            this.btnAgregar.Location = new System.Drawing.Point(544, 346);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 28);
            this.btnAgregar.TabIndex = 131;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMillas
            // 
            this.txtMillas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMillas.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMillas.Location = new System.Drawing.Point(686, 284);
            this.txtMillas.Name = "txtMillas";
            this.txtMillas.Size = new System.Drawing.Size(106, 20);
            this.txtMillas.TabIndex = 153;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(622, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 152;
            this.label8.Text = "Millas:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(686, 228);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(106, 21);
            this.cmbEstado.TabIndex = 151;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.Location = new System.Drawing.Point(686, 200);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(106, 20);
            this.txtTelefono.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(631, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 149;
            this.label1.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(686, 257);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(106, 21);
            this.cmbTipo.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(599, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 147;
            this.label6.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(456, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 20);
            this.txtEmail.TabIndex = 146;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(381, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 145;
            this.label5.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(611, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 144;
            this.label2.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(457, 228);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 143;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(457, 256);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(124, 20);
            this.txtApellido.TabIndex = 142;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Location = new System.Drawing.Point(458, 200);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(123, 20);
            this.txtId.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(407, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 140;
            this.label3.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(361, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 139;
            this.label9.Text = "Apellido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(362, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 138;
            this.label10.Text = "Nombre:";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.proyecto_sitemas_search;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.txtMillas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.btnAgregar);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ListView listClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMillas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader email;
    }
}