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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.obrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaObraSocialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrasSocialesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(855, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // obrasSocialesToolStripMenuItem
            // 
            this.obrasSocialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaObraSocialToolStripMenuItem,
            this.consultaObraSocialToolStripMenuItem});
            this.obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            this.obrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            // 
            // altaObraSocialToolStripMenuItem
            // 
            this.altaObraSocialToolStripMenuItem.Name = "altaObraSocialToolStripMenuItem";
            this.altaObraSocialToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.altaObraSocialToolStripMenuItem.Text = "Alta Obra Social";
            this.altaObraSocialToolStripMenuItem.Click += new System.EventHandler(this.altaObraSocialToolStripMenuItem_Click);
            // 
            // consultaObraSocialToolStripMenuItem
            // 
            this.consultaObraSocialToolStripMenuItem.Name = "consultaObraSocialToolStripMenuItem";
            this.consultaObraSocialToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.consultaObraSocialToolStripMenuItem.Text = "Consulta Obras Sociales";
            this.consultaObraSocialToolStripMenuItem.Click += new System.EventHandler(this.consultaObraSocialToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem,
            this.consultaObraSocialToolStripMenuItem1});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.altaClienteToolStripMenuItem.Text = "Alta Cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // consultaObraSocialToolStripMenuItem1
            // 
            this.consultaObraSocialToolStripMenuItem1.Name = "consultaObraSocialToolStripMenuItem1";
            this.consultaObraSocialToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.consultaObraSocialToolStripMenuItem1.Text = "Consulta Clientes";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProductoToolStripMenuItem,
            this.consultaProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(12, 77);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(709, 282);
            this.pnlContent.TabIndex = 2;
            // 
            // altaProductoToolStripMenuItem
            // 
            this.altaProductoToolStripMenuItem.Name = "altaProductoToolStripMenuItem";
            this.altaProductoToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.altaProductoToolStripMenuItem.Text = "Alta Producto";
            // 
            // consultaProductosToolStripMenuItem
            // 
            this.consultaProductosToolStripMenuItem.Name = "consultaProductosToolStripMenuItem";
            this.consultaProductosToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.consultaProductosToolStripMenuItem.Text = "Consulta Productos";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 399);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Home";
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
        private System.Windows.Forms.ToolStripMenuItem consultaObraSocialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaProductosToolStripMenuItem;
    }
}