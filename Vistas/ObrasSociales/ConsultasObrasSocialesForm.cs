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
using Vistas.Principal;

namespace Vistas.ObrasSociales
{
    public partial class ConsultasObrasSocialesForm : FormBase
    {
        public ConsultasObrasSocialesForm()
        {
            InitializeComponent();
        }

        private void ConsultasObrasSocialesForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ObraSocialService.FindAllObrasSociales();

        }

        private void btnEliminarObraSocial_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string cuitObra = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();

                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar esta Obra Social?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (r == DialogResult.Yes)
                {
                    ObraSocialService.EliminarObraSocial(cuitObra);
                    dataGridView1.DataSource = ObraSocialService.FindAllObrasSociales();

                }
            }
        }

    }
}
