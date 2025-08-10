using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace csharp_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
                dataGridView1.Rows.Add();
        }

        private void НазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Application.OpenForms[0].Show();
        }

        private void ПускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            for (int i = 0; i < 10; i++)
            {
                dataGridView1[2, i].Value = "";
                double x = Convert.ToDouble(dataGridView1[0, i].Value);
                double y = Convert.ToDouble(dataGridView1[1, i].Value);
                bool inside = (x * x + y * y) <= (r * r);
                double angle = Math.Atan2(y, x) * (180.0 / Math.PI);
                bool inShadedArea = (angle >= 45 && angle <= 90) || (angle >= 225 && angle <= 270);
                if (angle < 0) angle += 360;

                if (inside && inShadedArea) dataGridView1[2, i].Value = "ДА";
                else dataGridView1[2, i].Value = "НЕТ";
            }
        }
    }
}