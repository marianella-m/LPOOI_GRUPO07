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
        }

        List<Rol> roles = new List<Rol>();
        List<Usuario> usuarios = new List<Usuario>();

        Color backColorOriginal;
        Color foreColorOriginal;
        Font fontOriginal;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

            backColorOriginal = btnLogin.BackColor;
            foreColorOriginal = btnLogin.ForeColor;
            fontOriginal = btnLogin.Font;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            { 
                MessageBox.Show("Usuario y contraseña son campos requeridos, no pueden estar vacios", "Ingreso invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Usuario usuarioLoggeado = LoginService.loginDB(username, password);

            if (usuarioLoggeado != null)
            {
                new Home(usuarioLoggeado).Show();
                this.Hide();
            }else {
                MessageBox.Show("Usuario y password incorrectos", "Ingreso invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar.Equals('*')) {
                txtPassword.PasswordChar = '\0';
                btnShowHidePassword.Image = Properties.Resources.hide;
            }
            else { 
                txtPassword.PasswordChar = '*';
                btnShowHidePassword.Image = Properties.Resources.view__2_;
            }
        }

        private void validateDatabaseConnection() {
            string nombreConexion = "opticaConnection";

            try
            {
                string cadena = ConfigurationManager.ConnectionStrings[nombreConexion].ConnectionString;
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    this.Text += " - BD Conectada";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de base de datos: " + ex.Message,
                                "Error de Inicio",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font(btnLogin.Font, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font(btnLogin.Font, FontStyle.Bold);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = backColorOriginal;
            btnLogin.ForeColor = foreColorOriginal;
            btnLogin.Font = fontOriginal;
        }
    }
}
