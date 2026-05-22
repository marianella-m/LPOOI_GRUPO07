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
    public partial class ConsultaVentasForm : Form
    {
        public ConsultaVentasForm()
        {
            InitializeComponent();
        }

        private void ConsultaVentasForm_Load(object sender, EventArgs e)
        {
            dtGridVentas.DataSource = VentaService.FindAllVentas();
        }

    }
}
