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
            this.altaProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.productosToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 16, 0, 16);
            this.menuPrincipal.Size = new System.Drawing.Size(1018, 51);
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
            this.consultaObraSocialToolStripMenuItem1});
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
            // consultaObraSocialToolStripMenuItem1
            // 
            this.consultaObraSocialToolStripMenuItem1.Name = "consultaObraSocialToolStripMenuItem1";
            this.consultaObraSocialToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.consultaObraSocialToolStripMenuItem1.Text = "Consulta Clientes";
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
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(9, 63);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 419);
            this.pnlContent.TabIndex = 2;
            // 
            // btnCloseSession
            // 
            this.btnCloseSession.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSession.Location = new System.Drawing.Point(953, 10);
            this.btnCloseSession.Margin = new System.Windows.Forms.Padding(2);
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
            this.ClientSize = new System.Drawing.Size(1018, 504);
            this.Controls.Add(this.btnCloseSession);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnCloseSession;
    }
}