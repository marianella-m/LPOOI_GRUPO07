using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Vistas
{
    public static class NavigationManager
    {   
       public static void Navigate(Panel contentPanel, Form form) {
           contentPanel.Controls.Clear();
           form.TopLevel = false;
           form.FormBorderStyle = FormBorderStyle.None;
           form.Dock = DockStyle.Fill;

           form.StartPosition = FormStartPosition.Manual;
           var areaTrabajo = Screen.PrimaryScreen.WorkingArea;
           int width = (int)(areaTrabajo.Width * 0.75);
           int height = (int)(areaTrabajo.Height * 0.75);
           form.Size = new Size(width, height);
           form.Left = (areaTrabajo.Width - width) / 2;
           form.Top = (areaTrabajo.Height - height) / 2;

           contentPanel.Controls.Add(form);
           form.Show();
       }
    }
}
