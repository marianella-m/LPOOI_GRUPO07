namespace Vistas
{
    partial class ConsultaVentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentasForm));
            this.dtGridVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.btnConsultarVentasCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtVentaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtVentaFin = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarbyRango = new System.Windows.Forms.Button();
            this.dtGridFechas = new System.Windows.Forms.DataGridView();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.lblTotalVentasPorCliente = new System.Windows.Forms.Label();
            this.lblTotalVentasPorRangoFechas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridVentas
            // 
            this.dtGridVentas.AllowUserToAddRows = false;
            this.dtGridVentas.AllowUserToDeleteRows = false;
            this.dtGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVentas.Location = new System.Drawing.Point(66, 187);
            this.dtGridVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGridVentas.Name = "dtGridVentas";
            this.dtGridVentas.ReadOnly = true;
            this.dtGridVentas.RowTemplate.Height = 24;
            this.dtGridVentas.Size = new System.Drawing.Size(464, 287);
            this.dtGridVentas.TabIndex = 0;
            this.dtGridVentas.Click += new System.EventHandler(this.dtGridVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTA VENTAS";
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(219, 93);
            this.comboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(160, 24);
            this.comboClientes.TabIndex = 2;
            // 
            // btnConsultarVentasCliente
            // 
            this.btnConsultarVentasCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarVentasCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarVentasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVentasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVentasCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarVentasCliente.Location = new System.Drawing.Point(207, 137);
            this.btnConsultarVentasCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarVentasCliente.Name = "btnConsultarVentasCliente";
            this.btnConsultarVentasCliente.Size = new System.Drawing.Size(188, 28);
            this.btnConsultarVentasCliente.TabIndex = 3;
            this.btnConsultarVentasCliente.Text = "CONSULTAR VENTAS";
            this.btnConsultarVentasCliente.UseVisualStyleBackColor = false;
            this.btnConsultarVentasCliente.Click += new System.EventHandler(this.btnConsultarVentasCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "LISTADO DE VENTAS POR CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "LISTADO DE VENTAS POR FECHA";
            // 
            // dtVentaInicio
            // 
            this.dtVentaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVentaInicio.Location = new System.Drawing.Point(706, 94);
            this.dtVentaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtVentaInicio.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtVentaInicio.Name = "dtVentaInicio";
            this.dtVentaInicio.Size = new System.Drawing.Size(129, 22);
            this.dtVentaInicio.TabIndex = 6;
            this.dtVentaInicio.Value = new System.DateTime(2026, 5, 24, 23, 59, 0, 0);
            // 
            // dtVentaFin
            // 
            this.dtVentaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVentaFin.Location = new System.Drawing.Point(859, 96);
            this.dtVentaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtVentaFin.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtVentaFin.Name = "dtVentaFin";
            this.dtVentaFin.Size = new System.Drawing.Size(129, 22);
            this.dtVentaFin.TabIndex = 7;
            this.dtVentaFin.Value = new System.DateTime(2026, 5, 26, 23, 59, 0, 0);
            // 
            // btnConsultarbyRango
            // 
            this.btnConsultarbyRango.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarbyRango.FlatAppearance.BorderSize = 0;
            this.btnConsultarbyRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarbyRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarbyRango.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarbyRango.Location = new System.Drawing.Point(757, 137);
            this.btnConsultarbyRango.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarbyRango.Name = "btnConsultarbyRango";
            this.btnConsultarbyRango.Size = new System.Drawing.Size(188, 28);
            this.btnConsultarbyRango.TabIndex = 8;
            this.btnConsultarbyRango.Text = "CONSULTAR VENTAS";
            this.btnConsultarbyRango.UseVisualStyleBackColor = false;
            this.btnConsultarbyRango.Click += new System.EventHandler(this.btnConsultarbyRango_Click);
            // 
            // dtGridFechas
            // 
            this.dtGridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFechas.Location = new System.Drawing.Point(614, 187);
            this.dtGridFechas.Margin = new System.Windows.Forms.Padding(4);
            this.dtGridFechas.Name = "dtGridFechas";
            this.dtGridFechas.Size = new System.Drawing.Size(468, 287);
            this.dtGridFechas.TabIndex = 9;
            this.dtGridFechas.Click += new System.EventHandler(this.dtGridFechas_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarVenta.Location = new System.Drawing.Point(449, 505);
            this.btnEliminarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(219, 38);
            this.btnEliminarVenta.TabIndex = 10;
            this.btnEliminarVenta.Text = "ELIMINAR VENTA";
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // lblTotalVentasPorCliente
            // 
            this.lblTotalVentasPorCliente.AutoSize = true;
            this.lblTotalVentasPorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentasPorCliente.Location = new System.Drawing.Point(33, 505);
            this.lblTotalVentasPorCliente.Name = "lblTotalVentasPorCliente";
            this.lblTotalVentasPorCliente.Size = new System.Drawing.Size(0, 20);
            this.lblTotalVentasPorCliente.TabIndex = 11;
            this.lblTotalVentasPorCliente.Visible = false;
            // 
            // lblTotalVentasPorRangoFechas
            // 
            this.lblTotalVentasPorRangoFechas.AutoSize = true;
            this.lblTotalVentasPorRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentasPorRangoFechas.Location = new System.Drawing.Point(581, 505);
            this.lblTotalVentasPorRangoFechas.Name = "lblTotalVentasPorRangoFechas";
            this.lblTotalVentasPorRangoFechas.Size = new System.Drawing.Size(0, 20);
            this.lblTotalVentasPorRangoFechas.TabIndex = 12;
            // 
            // ConsultaVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 574);
            this.Controls.Add(this.lblTotalVentasPorRangoFechas);
            this.Controls.Add(this.lblTotalVentasPorCliente);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.dtGridFechas);
            this.Controls.Add(this.btnConsultarbyRango);
            this.Controls.Add(this.dtVentaFin);
            this.Controls.Add(this.dtVentaInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarVentasCliente);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridVentas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultaVentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaVentaForm";
            this.Load += new System.EventHandler(this.ConsultaVentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Button btnConsultarVentasCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtVentaInicio;
        private System.Windows.Forms.DateTimePicker dtVentaFin;
        private System.Windows.Forms.Button btnConsultarbyRango;
        private System.Windows.Forms.DataGridView dtGridFechas;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Label lblTotalVentasPorCliente;
        private System.Windows.Forms.Label lblTotalVentasPorRangoFechas;


    }
}