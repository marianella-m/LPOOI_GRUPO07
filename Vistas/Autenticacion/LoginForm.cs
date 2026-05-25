using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using ClasesBase.services;
using System.Data.SqlClient;
using System.Configuration; 

namespace Vistas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtContrasenia.PasswordChar = '*';

            lblErrorNombreUsuario.Visible = false;
            lblErrorContrasenia.Visible = false;
        }

        // NAVEGACION ENTRE LOS CAMPOS

        /// <summary>
        /// Luego de validar que el campo nombre de usuario, no este vacio, avanza al siguiente campo al presionar enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;

                if (validarCampoUsuario())
                    txtContrasenia.Focus();
            }
        }

        /// <summary>
        /// Luego de validar que el campo contraseña, no este vacio, avanza al siguiente campo al presionar enter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;

                if (validarCampoContrasenia())
                    btnLogin_Click(btnLogin, EventArgs.Empty);
            }
        }

        // VALIDACIONES

        /// <summary>
        /// Retorna true si el campo nombre de usuario esta vacio.
        /// </summary>
        /// <returns></returns>
        private bool validarCampoUsuario() 
        {
            string nombreUsuario = txtNombreUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario)) 
            {
                lblErrorNombreUsuario.Visible = true;
                txtNombreUsuario.Focus();
                return false;
            }

            lblErrorNombreUsuario.Visible = false;
            return true;
        }

        /// <summary>
        /// Retorna true si el campo contraseña esta vacio.
        /// </summary>
        /// <returns></returns>
        private bool validarCampoContrasenia() 
        {
            string contrasenia = txtContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(contrasenia)) 
            {
                lblErrorContrasenia.Visible = true;
                txtContrasenia.Focus();
                return false;
            }
            
            lblErrorContrasenia.Visible = false;
            return true;
        }

        // BOTONES

        /// <summary>
        /// Muestra el contenido del campo contraseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowHidePassword_Click(object sender, EventArgs e) 
        {
            if (txtContrasenia.PasswordChar.Equals('*')) 
            {
                txtContrasenia.PasswordChar = '\0';
                btnShowHidePassword.Image = Properties.Resources.hide;
            } 
            else 
            {
                txtContrasenia.PasswordChar = '*';
                btnShowHidePassword.Image = Properties.Resources.view__2_;
            }
        }

        /// <summary>
        /// Mensaje de confirmacion luego de cerrar la ventana Inicio Sesion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) 
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        /// <summary>
        /// Luego de validar las credenciales de un usuario redirecciona al Menu Principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) 
        {
            string username = txtNombreUsuario.Text.Trim();
            string password = txtContrasenia.Text.Trim();

            Usuario usuarioLoggeado = LoginService.loginDB(username, password);

            if (usuarioLoggeado != null) 
            {
                new Home(usuarioLoggeado).Show();
                this.Hide();
            } 
            else 
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos. Verifique los datos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreUsuario.Focus();
            }
        }
    }
}