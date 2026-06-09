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





    }
}
