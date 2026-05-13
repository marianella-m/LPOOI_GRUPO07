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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.initRoles();
            this.initUsuarios();
            txtPassword.PasswordChar = '*';

            validateDatabaseConnection();
        }

        private void initRoles() {
            //Roles “Administrador”, “Operador” y “Auditor”
            roles.Add(new Rol(1, "Administrador"));
            roles.Add(new Rol(2, "Operador"));
            roles.Add(new Rol(3, "Auditor"));
        }

        private void initUsuarios() {
            usuarios.Add(new Usuario("admi123", "Admi2026", "Richard Rios", 1));
            usuarios.Add(new Usuario("oper123", "Oper2026", "Luis Suarez", 2));
            usuarios.Add(new Usuario("audi123", "Audi2026", "Pablo Perez", 3));
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
            Usuario usuarioLoggeado;
            usuarioLoggeado = LoginService.loginDB(username, password);
            if(usuarioLoggeado == null)
            usuarioLoggeado = LoginService.loginLista(this.usuarios, username, password);

            if (usuarioLoggeado != null)
            {
                new Home().Show();
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
        
    }
}
