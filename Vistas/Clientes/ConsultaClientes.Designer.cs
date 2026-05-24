namespace Vistas
{
    partial class ConsultaClientes
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
            this.dtGridClientes = new System.Windows.Forms.DataGridView();
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCuitOS = new System.Windows.Forms.TextBox();
            this.lblFilterDni = new System.Windows.Forms.Label();
            this.lblFilterCuitOS = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridClientes
            // 
            this.dtGridClientes.AllowUserToAddRows = false;
            this.dtGridClientes.AllowUserToDeleteRows = false;
            this.dtGridClientes.AllowUserToResizeColumns = false;
            this.dtGridClientes.AllowUserToResizeRows = false;
            this.dtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridClientes.Location = new System.Drawing.Point(28, 148);
            this.dtGridClientes.Name = "dtGridClientes";
            this.dtGridClientes.ReadOnly = true;
            this.dtGridClientes.RowTemplate.Height = 24;
            this.dtGridClientes.Size = new System.Drawing.Size(822, 208);
            this.dtGridClientes.TabIndex = 0;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(23, 19);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(113, 29);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(28, 89);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(164, 22);
            this.txtDni.TabIndex = 2;
            // 
            // txtCuitOS
            // 
            this.txtCuitOS.Location = new System.Drawing.Point(222, 89);
            this.txtCuitOS.Name = "txtCuitOS";
            this.txtCuitOS.Size = new System.Drawing.Size(148, 22);
            this.txtCuitOS.TabIndex = 3;
            // 
            // lblFilterDni
            // 
            this.lblFilterDni.AutoSize = true;
            this.lblFilterDni.Location = new System.Drawing.Point(25, 69);
            this.lblFilterDni.Name = "lblFilterDni";
            this.lblFilterDni.Size = new System.Drawing.Size(29, 17);
            this.lblFilterDni.TabIndex = 4;
            this.lblFilterDni.Text = "Dni";
            // 
            // lblFilterCuitOS
            // 
            this.lblFilterCuitOS.AutoSize = true;
            this.lblFilterCuitOS.Location = new System.Drawing.Point(219, 68);
            this.lblFilterCuitOS.Name = "lblFilterCuitOS";
            this.lblFilterCuitOS.Size = new System.Drawing.Size(110, 17);
            this.lblFilterCuitOS.TabIndex = 5;
            this.lblFilterCuitOS.Text = "Cuit Obra Social";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(398, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 29);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(666, 387);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 26);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(761, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 26);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 447);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFilterCuitOS);
            this.Controls.Add(this.lblFilterDni);
            this.Controls.Add(this.txtCuitOS);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.dtGridClientes);
            this.Name = "ConsultaClientes";
            this.Text = "Consulta Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCuitOS;
        private System.Windows.Forms.Label lblFilterDni;
        private System.Windows.Forms.Label lblFilterCuitOS;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}