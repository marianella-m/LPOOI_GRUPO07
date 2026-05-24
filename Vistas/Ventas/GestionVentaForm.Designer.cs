namespace Vistas
{
    partial class GestionVentaForm
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
            this.cmbBoxClientes = new System.Windows.Forms.ComboBox();
            this.dtTmPickerVenta = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.listViewProductos = new System.Windows.Forms.ListView();
            this.colHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridViewDetallesVenta = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblRegistroVenta = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.lblToast = new System.Windows.Forms.Label();
            this.errorProviderVenta = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallesVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoxClientes
            // 
            this.cmbBoxClientes.FormattingEnabled = true;
            this.cmbBoxClientes.Location = new System.Drawing.Point(48, 80);
            this.cmbBoxClientes.Name = "cmbBoxClientes";
            this.cmbBoxClientes.Size = new System.Drawing.Size(197, 24);
            this.cmbBoxClientes.TabIndex = 0;
            // 
            // dtTmPickerVenta
            // 
            this.dtTmPickerVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPickerVenta.Location = new System.Drawing.Point(312, 80);
            this.dtTmPickerVenta.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtTmPickerVenta.Name = "dtTmPickerVenta";
            this.dtTmPickerVenta.Size = new System.Drawing.Size(197, 22);
            this.dtTmPickerVenta.TabIndex = 1;
            this.dtTmPickerVenta.Value = new System.DateTime(2026, 5, 25, 23, 59, 59, 0);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(45, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(309, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // listViewProductos
            // 
            this.listViewProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderCodigo,
            this.colHeaderDescripcion,
            this.colHeaderPrecio});
            this.listViewProductos.FullRowSelect = true;
            this.listViewProductos.GridLines = true;
            this.listViewProductos.Location = new System.Drawing.Point(48, 160);
            this.listViewProductos.MultiSelect = false;
            this.listViewProductos.Name = "listViewProductos";
            this.listViewProductos.Size = new System.Drawing.Size(594, 157);
            this.listViewProductos.TabIndex = 4;
            this.listViewProductos.UseCompatibleStateImageBehavior = false;
            this.listViewProductos.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderCodigo
            // 
            this.colHeaderCodigo.Text = "Código";
            this.colHeaderCodigo.Width = 70;
            // 
            // colHeaderDescripcion
            // 
            this.colHeaderDescripcion.Text = "Descripción";
            this.colHeaderDescripcion.Width = 220;
            // 
            // colHeaderPrecio
            // 
            this.colHeaderPrecio.Text = "Precio";
            this.colHeaderPrecio.Width = 150;
            // 
            // dataGridViewDetallesVenta
            // 
            this.dataGridViewDetallesVenta.AllowUserToAddRows = false;
            this.dataGridViewDetallesVenta.AllowUserToResizeColumns = false;
            this.dataGridViewDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallesVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.productoDescripcion,
            this.precioProducto,
            this.cantidad,
            this.subtotal,
            this.deleteItem});
            this.dataGridViewDetallesVenta.Location = new System.Drawing.Point(48, 366);
            this.dataGridViewDetallesVenta.Name = "dataGridViewDetallesVenta";
            this.dataGridViewDetallesVenta.RowTemplate.Height = 24;
            this.dataGridViewDetallesVenta.Size = new System.Drawing.Size(1272, 136);
            this.dataGridViewDetallesVenta.TabIndex = 5;
            this.dataGridViewDetallesVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetallesVenta_CellContentClick);
            this.dataGridViewDetallesVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetallesVenta_CellEndEdit);
            // 
            // codigoProducto
            // 
            this.codigoProducto.Frozen = true;
            this.codigoProducto.HeaderText = "Código de Producto";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.ReadOnly = true;
            this.codigoProducto.Visible = false;
            // 
            // productoDescripcion
            // 
            this.productoDescripcion.Frozen = true;
            this.productoDescripcion.HeaderText = "Descripción de Producto";
            this.productoDescripcion.Name = "productoDescripcion";
            this.productoDescripcion.ReadOnly = true;
            this.productoDescripcion.Width = 250;
            // 
            // precioProducto
            // 
            this.precioProducto.Frozen = true;
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            this.precioProducto.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.Frozen = true;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 200;
            // 
            // deleteItem
            // 
            this.deleteItem.Frozen = true;
            this.deleteItem.HeaderText = "";
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Text = "Quitar Item";
            this.deleteItem.UseColumnTextForButtonValue = true;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(48, 128);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(88, 26);
            this.btnAgregarProducto.TabIndex = 6;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblRegistroVenta
            // 
            this.lblRegistroVenta.AutoSize = true;
            this.lblRegistroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroVenta.Location = new System.Drawing.Point(43, 9);
            this.lblRegistroVenta.Name = "lblRegistroVenta";
            this.lblRegistroVenta.Size = new System.Drawing.Size(185, 29);
            this.lblRegistroVenta.TabIndex = 7;
            this.lblRegistroVenta.Text = "Registro Venta";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(25, 534);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(127, 27);
            this.btnRegistrarVenta.TabIndex = 8;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // lblToast
            // 
            this.lblToast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToast.Location = new System.Drawing.Point(548, 80);
            this.lblToast.Name = "lblToast";
            this.lblToast.Size = new System.Drawing.Size(201, 47);
            this.lblToast.TabIndex = 15;
            this.lblToast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderVenta
            // 
            this.errorProviderVenta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderVenta.ContainerControl = this;
            // 
            // GestionVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 614);
            this.Controls.Add(this.lblToast);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.lblRegistroVenta);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dataGridViewDetallesVenta);
            this.Controls.Add(this.listViewProductos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dtTmPickerVenta);
            this.Controls.Add(this.cmbBoxClientes);
            this.Name = "GestionVentaForm";
            this.Text = "GestionVenta";
            this.Load += new System.EventHandler(this.GestionVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallesVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxClientes;
        private System.Windows.Forms.DateTimePicker dtTmPickerVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ListView listViewProductos;
        private System.Windows.Forms.DataGridView dataGridViewDetallesVenta;
        private System.Windows.Forms.ColumnHeader colHeaderCodigo;
        private System.Windows.Forms.ColumnHeader colHeaderDescripcion;
        private System.Windows.Forms.ColumnHeader colHeaderPrecio;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblRegistroVenta;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn deleteItem;
        private System.Windows.Forms.Label lblToast;
        private System.Windows.Forms.ErrorProvider errorProviderVenta;
    }
}