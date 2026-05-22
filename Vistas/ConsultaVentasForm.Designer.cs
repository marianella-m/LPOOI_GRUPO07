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
            this.dtGridVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridVentas
            // 
            this.dtGridVentas.AllowUserToAddRows = false;
            this.dtGridVentas.AllowUserToDeleteRows = false;
            this.dtGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVentas.Location = new System.Drawing.Point(49, 113);
            this.dtGridVentas.Name = "dtGridVentas";
            this.dtGridVentas.ReadOnly = true;
            this.dtGridVentas.RowTemplate.Height = 24;
            this.dtGridVentas.Size = new System.Drawing.Size(555, 325);
            this.dtGridVentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta Ventas";
            // 
            // ConsultaVentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridVentas);
            this.Name = "ConsultaVentasForm";
            this.Text = "ConsultaVentaForm";
            this.Load += new System.EventHandler(this.ConsultaVentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridVentas;
        private System.Windows.Forms.Label label1;


    }
}