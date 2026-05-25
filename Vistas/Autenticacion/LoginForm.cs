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

        List<Rol> roles = new List<Rol>();
        List<Usuario> usuarios = new List<Usuario>();

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = txtNombreUsuario.Text.Trim();
            string password = txtContrasenia.Text.Trim();

            Usuario usuarioLoggeado = LoginService.loginDB(username, password);

            if (usuarioLoggeado != null) {
                new Home(usuarioLoggeado).Show();
                this.Hide();
            } else {
                MessageBox.Show("El usuario o la contraseña son incorrectos. Verifique los datos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreUsuario.Focus();
            }
        }

        // Boton que muestra contraseña
        private void btnShowHidePassword_Click(object sender, EventArgs e) {
            if (txtContrasenia.PasswordChar.Equals('*')) {
                txtContrasenia.PasswordChar = '\0';
                btnShowHidePassword.Image = Properties.Resources.hide;
            } else {
                txtContrasenia.PasswordChar = '*';
                btnShowHidePassword.Image = Properties.Resources.view__2_;
            }
        }

        //Navegación
        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;

                if (validarCampoUsuario())
                    txtContrasenia.Focus();
            }
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;

                if (validarCampoContrasenia())
                    btnLogin_Click(btnLogin, EventArgs.Empty);
            }
        }

        // Validacion de cambos no vacios
        private bool validarCampoUsuario() {
            string nombreUsuario = txtNombreUsuario.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario)) {
                lblErrorNombreUsuario.Visible = true;
                txtNombreUsuario.Focus();
                return false;
            }

            lblErrorNombreUsuario.Visible = false;
            return true;
        }

        private bool validarCampoContrasenia() {
            string contrasenia = txtContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(contrasenia)) {
                lblErrorContrasenia.Visible = true;
                txtContrasenia.Focus();
                return false;
            }
            
            lblErrorContrasenia.Visible = false;
            return true;
       }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}