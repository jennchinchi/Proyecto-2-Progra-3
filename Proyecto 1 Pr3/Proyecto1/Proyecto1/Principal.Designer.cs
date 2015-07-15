namespace Presentacion
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buecarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiquetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarTiqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTiqueteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.tiquetesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.buecarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // buecarClienteToolStripMenuItem
            // 
            this.buecarClienteToolStripMenuItem.Name = "buecarClienteToolStripMenuItem";
            this.buecarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buecarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buecarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVuelosToolStripMenuItem,
            this.buscarVueloToolStripMenuItem});
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            // 
            // agregarVuelosToolStripMenuItem
            // 
            this.agregarVuelosToolStripMenuItem.Name = "agregarVuelosToolStripMenuItem";
            this.agregarVuelosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.agregarVuelosToolStripMenuItem.Text = "Agregar Vuelo";
            this.agregarVuelosToolStripMenuItem.Click += new System.EventHandler(this.agregarVuelosToolStripMenuItem_Click);
            // 
            // buscarVueloToolStripMenuItem
            // 
            this.buscarVueloToolStripMenuItem.Name = "buscarVueloToolStripMenuItem";
            this.buscarVueloToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.buscarVueloToolStripMenuItem.Text = "Buscar Vuelo";
            this.buscarVueloToolStripMenuItem.Click += new System.EventHandler(this.buscarVueloToolStripMenuItem_Click);
            // 
            // tiquetesToolStripMenuItem
            // 
            this.tiquetesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarTiqueteToolStripMenuItem,
            this.buscarTiqueteToolStripMenuItem});
            this.tiquetesToolStripMenuItem.Name = "tiquetesToolStripMenuItem";
            this.tiquetesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiquetesToolStripMenuItem.Text = "Tiquetes";
            // 
            // comprarTiqueteToolStripMenuItem
            // 
            this.comprarTiqueteToolStripMenuItem.Name = "comprarTiqueteToolStripMenuItem";
            this.comprarTiqueteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.comprarTiqueteToolStripMenuItem.Text = "Comprar Tiquete";
            this.comprarTiqueteToolStripMenuItem.Click += new System.EventHandler(this.comprarTiqueteToolStripMenuItem_Click);
            // 
            // buscarTiqueteToolStripMenuItem
            // 
            this.buscarTiqueteToolStripMenuItem.Name = "buscarTiqueteToolStripMenuItem";
            this.buscarTiqueteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.buscarTiqueteToolStripMenuItem.Text = "Buscar Tiquete";
            this.buscarTiqueteToolStripMenuItem.Click += new System.EventHandler(this.buscarTiqueteToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.proyecto_sitemas_login;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buecarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiquetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarTiqueteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTiqueteToolStripMenuItem;
    }
}