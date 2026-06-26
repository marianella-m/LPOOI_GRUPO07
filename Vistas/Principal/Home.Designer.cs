namespace Vistas
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.obrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClienteslToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnCloseSession = new System.Windows.Forms.Button();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrasSocialesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 16, 0, 16);
            this.menuPrincipal.Size = new System.Drawing.Size(996, 51);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // obrasSocialesToolStripMenuItem
            // 
            this.obrasSocialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaObraSocialToolStripMenuItem,
            this.consultaObraSocialToolStripMenuItem});
            this.obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            this.obrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            // 
            // altaObraSocialToolStripMenuItem
            // 
            this.altaObraSocialToolStripMenuItem.Name = "altaObraSocialToolStripMenuItem";
            this.altaObraSocialToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.altaObraSocialToolStripMenuItem.Text = "Alta Obra Social";
            this.altaObraSocialToolStripMenuItem.Click += new System.EventHandler(this.altaObraSocialToolStripMenuItem_Click);
            // 
            // consultaObraSocialToolStripMenuItem
            // 
            this.consultaObraSocialToolStripMenuItem.Name = "consultaObraSocialToolStripMenuItem";
            this.consultaObraSocialToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.consultaObraSocialToolStripMenuItem.Text = "Consulta Obras Sociales";
            this.consultaObraSocialToolStripMenuItem.Click += new System.EventHandler(this.consultaObraSocialToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.consultaClienteslToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaClienteToolStripMenuItem.Text = "Alta Cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // consultaClienteslToolStripMenuItem
            // 
            this.consultaClienteslToolStripMenuItem.Name = "consultaClienteslToolStripMenuItem";
            this.consultaClienteslToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.consultaClienteslToolStripMenuItem.Text = "Consulta Clientes";
            this.consultaClienteslToolStripMenuItem.Click += new System.EventHandler(this.consultaClienteslToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProductoToolStripMenuItem,
            this.consultaProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.altaProductoToolStripMenuItem.Text = "Alta Producto";
            this.altaProductoToolStripMenuItem.Click += new System.EventHandler(this.altaProductoToolStripMenuItem_Click);
            // 
            // consultaProductosToolStripMenuItem
            // 
            this.consultaProductosToolStripMenuItem.Name = "consultaProductosToolStripMenuItem";
            this.consultaProductosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consultaProductosToolStripMenuItem.Text = "Consulta Productos";
            this.consultaProductosToolStripMenuItem.Click += new System.EventHandler(this.consultaProductosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUsuarioToolStripMenuItem,
            this.consultarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // altaUsuarioToolStripMenuItem
            // 
            this.altaUsuarioToolStripMenuItem.Name = "altaUsuarioToolStripMenuItem";
            this.altaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.altaUsuarioToolStripMenuItem.Text = "Alta Usuario";
            this.altaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaUsuarioToolStripMenuItem_Click);
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultarUsuariosToolStripMenuItem.Text = "Consulta Usuarios";
            this.consultarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuariosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentasToolStripMenuItem,
            this.consultarVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentasToolStripMenuItem
            // 
            this.registrarVentasToolStripMenuItem.Name = "registrarVentasToolStripMenuItem";
            this.registrarVentasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registrarVentasToolStripMenuItem.Text = "Registrar Ventas";
            this.registrarVentasToolStripMenuItem.Click += new System.EventHandler(this.registrarVentasToolStripMenuItem_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarVentasToolStripMenuItem.Text = "Consultar Ventas";
            this.consultarVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(9, 63);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(868, 495);
            this.pnlContent.TabIndex = 2;
            // 
            // btnCloseSession
            // 
            this.btnCloseSession.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSession.Location = new System.Drawing.Point(417, 11);
            this.btnCloseSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseSession.Name = "btnCloseSession";
            this.btnCloseSession.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnCloseSession.Size = new System.Drawing.Size(56, 32);
            this.btnCloseSession.TabIndex = 3;
            this.btnCloseSession.Text = "Salir";
            this.btnCloseSession.UseVisualStyleBackColor = true;
            this.btnCloseSession.Click += new System.EventHandler(this.btnCloseSession_Click);
            this.btnCloseSession.MouseLeave += new System.EventHandler(this.btnCloseSession_MouseLeave);
            this.btnCloseSession.MouseHover += new System.EventHandler(this.btnCloseSession_MouseHover);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 578);
            this.Controls.Add(this.btnCloseSession);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem altaObraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaObraSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClienteslToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProductosToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseSession;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
    }
}