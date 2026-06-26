using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.services;
using ClasesBase;
using Vistas.Principal;

namespace Vistas
{
    public partial class Home : FormBase
    {
        Usuario usuarioActual = null;

        public Home(Usuario u)
        {
            InitializeComponent();
            usuarioActual = u;
        }

        Font fuenteOriginal ;

        private void Home_Load(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            fuenteOriginal = btnCloseSession.Font;

            btnCloseSession.BackColor = Color.FromArgb(220, 90, 90);
            btnCloseSession.ForeColor = Color.White;
            restricciones(usuarioActual);
        }

        private void altaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new AltaObraSocialForm());
        }

        // funcionalidad a boton en pestaña cliente -> alta cliente
        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new AltaClienteForm());
        }

        private void consultaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new ConsultaObrasSocialesForm());
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {   //el cierre de la aplicación se delega al cierre de este formulario
            Application.Exit();
        }

        private void btnCloseSession_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea cerrar sesión?", "Cierre de sesión", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
                this.Close();
        }

        private void btnCloseSession_MouseHover(object sender, EventArgs e)
        {
            btnCloseSession.BackColor = Color.FromArgb(200, 60, 60);
            btnCloseSession.ForeColor = Color.White;

            btnCloseSession.Font = new Font(btnCloseSession.Font, FontStyle.Bold);
        }

        private void btnCloseSession_MouseLeave(object sender, EventArgs e)
        {
            btnCloseSession.BackColor = Color.FromArgb(220, 90, 90);
            btnCloseSession.ForeColor = Color.White;

            btnCloseSession.Font = fuenteOriginal;
        }

        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new AltaProductosForm());
        }

        private void consultaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Navigate(pnlContent, new ConsultaProductos());
        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new AltaUsuario(0));
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new ConsultaUsuarios(this.usuarioActual));
        }

        private void restricciones(Usuario u)
        {
            if (u.Rol_Codigo == 1) //Administrador
            {
                usuariosToolStripMenuItem.Enabled = true;
                productosToolStripMenuItem.Enabled = true;

                clientesToolStripMenuItem.Enabled = false;
                obrasSocialesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = false;
            }

            else if (u.Rol_Codigo == 3) //Operador
            {
                usuariosToolStripMenuItem.Enabled = false;
                productosToolStripMenuItem.Enabled = false;

                clientesToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
            }

            else if (u.Rol_Codigo == 2) //Auditor
            {
                usuariosToolStripMenuItem.Enabled = true;
                productosToolStripMenuItem.Enabled = true;

                clientesToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
            }
        }

        private void registrarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new GestionVentaForm());
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new ConsultaVentasForm());
        }

        private void consultaClienteslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Navigate(pnlContent, new ConsultaClientes());
        }

        
    }
}
