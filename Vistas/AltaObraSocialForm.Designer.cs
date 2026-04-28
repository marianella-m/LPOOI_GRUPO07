namespace Vistas
{
    partial class AltaObraSocialForm
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
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveObraSocial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(65, 49);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(197, 22);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Enter += new System.EventHandler(this.txtCuit_Enter);
            this.txtCuit.Leave += new System.EventHandler(this.txtCuit_Leave);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(65, 77);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(197, 22);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(65, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(197, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCuit);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(47, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Obra Social";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(65, 133);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveObraSocial);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(24, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 346);
            this.panel1.TabIndex = 8;
            // 
            // btnSaveObraSocial
            // 
            this.btnSaveObraSocial.Location = new System.Drawing.Point(58, 240);
            this.btnSaveObraSocial.Name = "btnSaveObraSocial";
            this.btnSaveObraSocial.Size = new System.Drawing.Size(130, 42);
            this.btnSaveObraSocial.TabIndex = 9;
            this.btnSaveObraSocial.Text = "Guardar Obra Social";
            this.btnSaveObraSocial.UseVisualStyleBackColor = true;
            this.btnSaveObraSocial.Click += new System.EventHandler(this.btnSaveObraSocial_Click);
            // 
            // AltaObraSocialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 536);
            this.Controls.Add(this.panel1);
            this.Name = "AltaObraSocialForm";
            this.Text = "AltaObraSocialForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnSaveObraSocial;
    }
}