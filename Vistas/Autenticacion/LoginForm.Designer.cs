namespace Vistas
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnShowHidePassword = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picContrasenia = new System.Windows.Forms.PictureBox();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.picLentes = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblErrorContrasenia = new System.Windows.Forms.Label();
            this.lblErrorNombreUsuario = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineUsuario = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasenia)).BeginInit();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLentes)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(102, 133);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(162, 17);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreUsuario_KeyDown);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.AliceBlue;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(103, 186);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(162, 17);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(126, 261);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 31);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowHidePassword.BackgroundImage")));
            this.btnShowHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowHidePassword.Location = new System.Drawing.Point(269, 186);
            this.btnShowHidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(26, 24);
            this.btnShowHidePassword.TabIndex = 9;
            this.btnShowHidePassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnShowHidePassword.UseVisualStyleBackColor = false;
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(60, 133);
            this.picUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(39, 24);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 6;
            this.picUsuario.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(67, 60);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Inicio de Sesión";
            // 
            // picContrasenia
            // 
            this.picContrasenia.Image = ((System.Drawing.Image)(resources.GetObject("picContrasenia.Image")));
            this.picContrasenia.Location = new System.Drawing.Point(60, 186);
            this.picContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.picContrasenia.Name = "picContrasenia";
            this.picContrasenia.Size = new System.Drawing.Size(39, 24);
            this.picContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContrasenia.TabIndex = 7;
            this.picContrasenia.TabStop = false;
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlImagen.BackgroundImage")));
            this.pnlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImagen.Controls.Add(this.picLentes);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(200, 336);
            this.pnlImagen.TabIndex = 8;
            // 
            // picLentes
            // 
            this.picLentes.BackColor = System.Drawing.Color.Transparent;
            this.picLentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLentes.BackgroundImage")));
            this.picLentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLentes.Location = new System.Drawing.Point(0, 109);
            this.picLentes.Name = "picLentes";
            this.picLentes.Size = new System.Drawing.Size(200, 112);
            this.picLentes.TabIndex = 0;
            this.picLentes.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlLogin.Controls.Add(this.lblErrorContrasenia);
            this.pnlLogin.Controls.Add(this.lblErrorNombreUsuario);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnShowHidePassword);
            this.pnlLogin.Controls.Add(this.txtNombreUsuario);
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Controls.Add(this.picUsuario);
            this.pnlLogin.Controls.Add(this.txtContrasenia);
            this.pnlLogin.Controls.Add(this.picContrasenia);
            this.pnlLogin.Controls.Add(this.shapeContainer1);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(200, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(334, 336);
            this.pnlLogin.TabIndex = 9;
            // 
            // lblErrorContrasenia
            // 
            this.lblErrorContrasenia.AutoSize = true;
            this.lblErrorContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorContrasenia.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblErrorContrasenia.Location = new System.Drawing.Point(102, 212);
            this.lblErrorContrasenia.Name = "lblErrorContrasenia";
            this.lblErrorContrasenia.Size = new System.Drawing.Size(108, 15);
            this.lblErrorContrasenia.TabIndex = 12;
            this.lblErrorContrasenia.Text = "Campo obligatorio";
            // 
            // lblErrorNombreUsuario
            // 
            this.lblErrorNombreUsuario.AutoSize = true;
            this.lblErrorNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombreUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblErrorNombreUsuario.Location = new System.Drawing.Point(102, 158);
            this.lblErrorNombreUsuario.Name = "lblErrorNombreUsuario";
            this.lblErrorNombreUsuario.Size = new System.Drawing.Size(108, 15);
            this.lblErrorNombreUsuario.TabIndex = 11;
            this.lblErrorNombreUsuario.Text = "Campo obligatorio";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineUsuario});
            this.shapeContainer1.Size = new System.Drawing.Size(334, 336);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 102;
            this.lineShape1.X2 = 262;
            this.lineShape1.Y1 = 209;
            this.lineShape1.Y2 = 209;
            // 
            // lineUsuario
            // 
            this.lineUsuario.BorderWidth = 2;
            this.lineUsuario.Name = "lineUsuario";
            this.lineUsuario.X1 = 102;
            this.lineUsuario.X2 = 262;
            this.lineUsuario.Y1 = 155;
            this.lineUsuario.Y2 = 155;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 336);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasenia)).EndInit();
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLentes)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picContrasenia;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnShowHidePassword;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.PictureBox picLentes;
        private System.Windows.Forms.Panel pnlLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineUsuario;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblErrorContrasenia;
        private System.Windows.Forms.Label lblErrorNombreUsuario;

    }
}

