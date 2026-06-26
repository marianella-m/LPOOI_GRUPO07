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
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridVentas
            // 
            this.dtGridVentas.AllowUserToAddRows = false;
            this.dtGridVentas.AllowUserToDeleteRows = false;
            this.dtGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVentas.Location = new System.Drawing.Point(30, 185);
            this.dtGridVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtGridVentas.Name = "dtGridVentas";
            this.dtGridVentas.ReadOnly = true;
            this.dtGridVentas.RowTemplate.Height = 24;
            this.dtGridVentas.Size = new System.Drawing.Size(348, 233);
            this.dtGridVentas.TabIndex = 0;
            this.dtGridVentas.Click += new System.EventHandler(this.dtGridVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSULTA VENTAS";
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(145, 109);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(121, 21);
            this.comboClientes.TabIndex = 2;
            // 
            // btnConsultarVentasCliente
            // 
            this.btnConsultarVentasCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultarVentasCliente.FlatAppearance.BorderSize = 0;
            this.btnConsultarVentasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVentasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVentasCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultarVentasCliente.Location = new System.Drawing.Point(136, 145);
            this.btnConsultarVentasCliente.Name = "btnConsultarVentasCliente";
            this.btnConsultarVentasCliente.Size = new System.Drawing.Size(141, 23);
            this.btnConsultarVentasCliente.TabIndex = 3;
            this.btnConsultarVentasCliente.Text = "CONSULTAR VENTAS";
            this.btnConsultarVentasCliente.UseVisualStyleBackColor = false;
            this.btnConsultarVentasCliente.Click += new System.EventHandler(this.btnConsultarVentasCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LISTADO DE VENTAS POR CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LISTADO DE VENTAS POR FECHA";
            // 
            // dtVentaInicio
            // 
            this.dtVentaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVentaInicio.Location = new System.Drawing.Point(510, 110);
            this.dtVentaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtVentaInicio.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtVentaInicio.Name = "dtVentaInicio";
            this.dtVentaInicio.Size = new System.Drawing.Size(98, 20);
            this.dtVentaInicio.TabIndex = 6;
            this.dtVentaInicio.Value = new System.DateTime(2026, 5, 24, 23, 59, 0, 0);
            // 
            // dtVentaFin
            // 
            this.dtVentaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVentaFin.Location = new System.Drawing.Point(625, 111);
            this.dtVentaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtVentaFin.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtVentaFin.Name = "dtVentaFin";
            this.dtVentaFin.Size = new System.Drawing.Size(98, 20);
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
            this.btnConsultarbyRango.Location = new System.Drawing.Point(548, 145);
            this.btnConsultarbyRango.Name = "btnConsultarbyRango";
            this.btnConsultarbyRango.Size = new System.Drawing.Size(141, 23);
            this.btnConsultarbyRango.TabIndex = 8;
            this.btnConsultarbyRango.Text = "CONSULTAR VENTAS";
            this.btnConsultarbyRango.UseVisualStyleBackColor = false;
            this.btnConsultarbyRango.Click += new System.EventHandler(this.btnConsultarbyRango_Click);
            // 
            // dtGridFechas
            // 
            this.dtGridFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFechas.Location = new System.Drawing.Point(441, 185);
            this.dtGridFechas.Name = "dtGridFechas";
            this.dtGridFechas.Size = new System.Drawing.Size(351, 233);
            this.dtGridFechas.TabIndex = 9;
            this.dtGridFechas.Click += new System.EventHandler(this.dtGridFechas_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarVenta.Location = new System.Drawing.Point(331, 465);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(164, 31);
            this.btnEliminarVenta.TabIndex = 10;
            this.btnEliminarVenta.Text = "ELIMINAR VENTA";
            this.btnEliminarVenta.UseVisualStyleBackColor = false;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // ConsultaVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 538);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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


    }
}