using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ClasesBase.services;
using ClasesBase;

namespace Vistas
{
    public partial class AltaUsuario : Form
    {
        int id;
        public AltaUsuario(int id)
        {
            this.id = id;
            InitializeComponent();
            if (id != 0){
                txtTitulo.Text = "Modificar Usuarios";
                modificar_usuario(id);

            }
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                load_combo_roles();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de base de datos: " + ex.Message,
                                "Error de Inicio",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_combo_roles(){
            comboRol.DisplayMember = "Rol_Descripcion";
            comboRol.ValueMember = "Rol_Codigo";
            comboRol.DataSource = UsuarioService.list_roles();
        }

        private void btnSaveUsuario_Click(object sender, EventArgs e)
        {
            int rol = (int)comboRol.SelectedValue;
            string apellidoNombre = txtApellidoNombre.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string pass = txtPassword.Text;

            StringBuilder errorMessageBuilder = new StringBuilder();

            validarCampos(errorMessageBuilder);

            if(!string.IsNullOrWhiteSpace(errorMessageBuilder.ToString())){
                MessageBox.Show(errorMessageBuilder.ToString(), "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string messageProperties = "Nombre de Usuario: " +
                nombreUsuario + "\nContraseña: " +
                pass + "\nApellido y Nombre: " +
                apellidoNombre + "\nRol: " +
                comboRol.Text;

            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres guardar este usuario?\n\n" + messageProperties, "Confirmar guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) {
                Usuario oUser = new Usuario(nombreUsuario, pass, apellidoNombre, rol);
                if (this.id != 0)
                {
                    oUser.Usu_ID = id;
                    UsuarioService.update_usuario(oUser);
                    FormControlUtil.showToast(lblToast, "Modificado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                    this.Hide();
                }
                else
                {
                    UsuarioService.insert_usuario(oUser);
                    FormControlUtil.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                    clearControls();
                }
            }
        }

        private void clearControls()
        {
            txtApellidoNombre.Clear();
            txtNombreUsuario.Clear();
            txtPassword.Clear();
        }

        private void validarCampos(StringBuilder errorMessageBuilder)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                errorMessageBuilder.AppendLine("Nombre de Usuario es campo requerido");
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorMessageBuilder.AppendLine("Contraseña es campo requerido");
            }
            
            if (string.IsNullOrWhiteSpace(txtApellidoNombre.Text))
            {
                errorMessageBuilder.AppendLine("Apellido y Nombre es campo requerido");
            }
        }

        private void modificar_usuario(int id){
            Usuario oUsu = UsuarioService.buscarPorId(id);
            txtNombreUsuario.Text = oUsu.Usu_NombreUsuario;
            txtPassword.Text = oUsu.Usu_Password;
            txtApellidoNombre.Text = oUsu.Usu_ApellidoNombre;
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar.Equals('*'))
            {
                txtPassword.PasswordChar = '\0';
                btnShowHidePassword.Image = Properties.Resources.hide;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowHidePassword.Image = Properties.Resources.view__2_;
            }
        }
    }
}
