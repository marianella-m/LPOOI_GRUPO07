using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.services;

namespace Vistas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            load_usuarios();
        }

        private void load_usuarios()
        {
            ListaUsuarios.DataSource = UsuarioService.list_usuarios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                ListaUsuarios.DataSource = UsuarioService.search_usuarios(txtBuscar.Text);
            }
            else{
                load_usuarios();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = (int) ListaUsuarios.CurrentRow.Cells["ID"].Value;
            new AltaUsuario(id).Show();
        }

        private void ListaUsuarios_MouseHover(object sender, EventArgs e)
        {
            load_usuarios();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios.CurrentRow != null){
                int id = Convert.ToInt32(ListaUsuarios.CurrentRow.Cells["ID"].Value);
                UsuarioService.delete_usuarios(id);
                load_usuarios();
            }
            else {
                MessageBox.Show("Seleccione un usuario");
            }
        }
    }
}
