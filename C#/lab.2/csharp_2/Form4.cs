using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void НазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Application.OpenForms[0].Show();
        }

        private void ПускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text); double y = Convert.ToDouble(textBox2.Text); double r = Convert.ToDouble(textBox3.Text);
            bool inside = (x * x + y * y) <= (r * r);
            double angle = Math.Atan2(y, x) * (180.0 / Math.PI);
            bool inShadedArea = (angle >= 45 && angle <= 90) || (angle >= 225 && angle <= 270);
            if (angle < 0) angle += 360;
            if (inside && inShadedArea) label3.Text = "ДА";
            else label3.Text = "НЕТ";
        }
    }
}
