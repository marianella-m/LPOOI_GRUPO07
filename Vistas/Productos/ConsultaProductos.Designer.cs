namespace Vistas
{
    partial class ConsultaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProductos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.rbDescripcion = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.cmBoxCliente = new System.Windows.Forms.ComboBox();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.btnConsultarbyRango = new System.Windows.Forms.Button();
            this.dtProductoFin = new System.Windows.Forms.DateTimePicker();
            this.dtProductoInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 273);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(601, 239);
            this.dgvProductos.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Consulta de Productos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(385, 67);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(112, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(520, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(353, 540);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 32);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(497, 540);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 32);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Location = new System.Drawing.Point(15, 73);
            this.rbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Size = new System.Drawing.Size(103, 21);
            this.rbDescripcion.TabIndex = 2;
            this.rbDescripcion.TabStop = true;
            this.rbDescripcion.Text = "Descripción";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(124, 73);
            this.rbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(90, 21);
            this.rbCategoria.TabIndex = 3;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoría";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(232, 62);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 32);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consultar productos por:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(15, 105);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(58, 17);
            this.lblClientes.TabIndex = 10;
            this.lblClientes.Text = "Clientes";
            // 
            // cmBoxCliente
            // 
            this.cmBoxCliente.FormattingEnabled = true;
            this.cmBoxCliente.Location = new System.Drawing.Point(82, 100);
            this.cmBoxCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmBoxCliente.Name = "cmBoxCliente";
            this.cmBoxCliente.Size = new System.Drawing.Size(160, 24);
            this.cmBoxCliente.TabIndex = 11;
            this.cmBoxCliente.SelectedIndexChanged += new System.EventHandler(this.cmBoxCliente_SelectedIndexChanged);
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCantidadTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTotal.Location = new System.Drawing.Point(15, 517);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(177, 25);
            this.lblCantidadTotal.TabIndex = 12;
            this.lblCantidadTotal.Text = "Total Productos: ";
            // 
            // btnConsultarbyRango
            // 
            this.btnConsultarbyRango.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarbyRango.FlatAppearance.BorderSize = 0;
            this.btnConsultarbyRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarbyRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarbyRango.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarbyRango.Location = new System.Drawing.Point(337, 186);
            this.btnConsultarbyRango.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarbyRango.Name = "btnConsultarbyRango";
            this.btnConsultarbyRango.Size = new System.Drawing.Size(116, 28);
            this.btnConsultarbyRango.TabIndex = 16;
            this.btnConsultarbyRango.Text = "FILTRAR";
            this.btnConsultarbyRango.UseVisualStyleBackColor = false;
            this.btnConsultarbyRango.Click += new System.EventHandler(this.btnConsultarbyRango_Click);
            // 
            // dtProductoFin
            // 
            this.dtProductoFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProductoFin.Location = new System.Drawing.Point(183, 188);
            this.dtProductoFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtProductoFin.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtProductoFin.Name = "dtProductoFin";
            this.dtProductoFin.Size = new System.Drawing.Size(129, 22);
            this.dtProductoFin.TabIndex = 15;
            this.dtProductoFin.Value = new System.DateTime(2026, 5, 26, 23, 59, 0, 0);
            // 
            // dtProductoInicio
            // 
            this.dtProductoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtProductoInicio.Location = new System.Drawing.Point(20, 188);
            this.dtProductoInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtProductoInicio.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtProductoInicio.Name = "dtProductoInicio";
            this.dtProductoInicio.Size = new System.Drawing.Size(129, 22);
            this.dtProductoInicio.TabIndex = 14;
            this.dtProductoInicio.Value = new System.DateTime(2026, 5, 24, 23, 59, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "LISTADO DE PRODUCTOS POR FECHA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 614);
            this.Controls.Add(this.btnConsultarbyRango);
            this.Controls.Add(this.dtProductoFin);
            this.Controls.Add(this.dtProductoInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.cmBoxCliente);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rbCategoria);
            this.Controls.Add(this.rbDescripcion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaProductos";
            this.Load += new System.EventHandler(this.ConsultaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.RadioButton rbDescripcion;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ComboBox cmBoxCliente;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Button btnConsultarbyRango;
        private System.Windows.Forms.DateTimePicker dtProductoFin;
        private System.Windows.Forms.DateTimePicker dtProductoInicio;
        private System.Windows.Forms.Label label3;
    }
}