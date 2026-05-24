using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas.Principal
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        public void Navigate(Panel contentPanel, Form form)
        {
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

        public void showToast(Label label, string mensaje, Color fontColor, Color backgroundColor)
        {
            label.Text = mensaje;
            label.ForeColor = fontColor;
            label.BackColor = backgroundColor;

            Timer t = new Timer();
            t.Interval = 4000;

            t.Tick += (s, e) =>
            {
                label.Text = "";
                label.BackColor = SystemColors.Control;
                t.Stop();
            };

            t.Start();
        }


        public void hidePlaceholder(TextBox txtBox, string placeholder)
        {
            if (txtBox.Text == placeholder)
                configTextBox(txtBox, "", Color.Black);
        }

        public void showPlaceholder(TextBox txtBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                configTextBox(txtBox, placeholder, Color.Gray);
        }

        public void configTextBox(TextBox txtBox, string placeholder, Color color)
        {
            txtBox.Text = placeholder;
            txtBox.ForeColor = color;
            txtBox.Font = new Font(txtBox.Font.FontFamily, 12);
        }
    }
}
