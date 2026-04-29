using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Font fuenteOriginal ;

        private void Home_Load(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            fuenteOriginal = btnCloseSession.Font;

            btnCloseSession.BackColor = Color.FromArgb(220, 90, 90);
            btnCloseSession.ForeColor = Color.White;
        }

        private void altaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationManager.Navigate(pnlContent, new AltaObraSocialForm());
        }

        // funcionalidad a boton en pestaña cliente -> alta cliente
        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigationManager.Navigate(pnlContent, new AltaClienteForm());
        }

        private void consultaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            TextBox txtBox = new TextBox();
            txtBox.Text = "Texto Ingresado......";
            pnlContent.Controls.Add(txtBox);
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
            NavigationManager.Navigate(pnlContent, new AltaProductosForm());
        }

        private void consultaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            TextBox txtBox = new TextBox();
            txtBox.Text = "Texto Ingresado......";
            pnlContent.Controls.Add(txtBox);
        }

    }
}
