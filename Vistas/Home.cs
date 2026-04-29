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

        private void Home_Load(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
        }

        private void altaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            NavigationManager.Navigate(pnlContent, new AltaObraSocialForm());

        }

        // funcionalidad a boton en pestaña cliente -> alta cliente
        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaClienteForm formAltaCliente = new AltaClienteForm();
            formAltaCliente.Show();
            this.Hide();
        }

        //private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    pnlContent.Controls.Clear();
        //    Label label = new Label();
        //    label.Text = "Label creado";
        //    pnlContent.Controls.Add(label);
        //}

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

    }
}
