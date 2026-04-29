using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Vistas
{
    class FormControlUtil
    {
        public static void showToast(Label label, string mensaje, Color fontColor, Color backgroundColor)
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


        public static void hidePlaceholder(TextBox txtBox, string placeholder)
        {
            if (txtBox.Text == placeholder)
                configTextBox(txtBox, "", Color.Black);
        }

        public static void showPlaceholder(TextBox txtBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                configTextBox(txtBox, placeholder, Color.Gray);
        }

        public static void configTextBox(TextBox txtBox, string placeholder, Color color)
        {
            txtBox.Text = placeholder;
            txtBox.ForeColor = color;
            txtBox.Font = new Font(txtBox.Font.FontFamily, 12);
        }
    }
}
