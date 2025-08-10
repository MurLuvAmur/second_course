using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Application.OpenForms[0].Show();
        }

        private void ПускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double xbeg = Convert.ToDouble(textBox1.Text), xend = Convert.ToDouble(textBox2.Text), dx = Convert.ToDouble(textBox3.Text), y = 0;
            chart1.Series[0].Points.Clear();
            dataGridView1.Rows.Clear();
            for (double x = xbeg; x <= xend; x += dx)
            {
                if (x >= -9 && x <= -6) y = -(Math.Sqrt(9 - (x + 6) * (x + 6)));
                else if (x >= -6 && x <= -3) y = x + 3;
                else if (x >= -3 && x <= 0) y = Math.Sqrt(9 - x * x);
                else if (x >= 0 && x <= 3) y = 3 - x;
                else if (x >= 3 && x <= 9) y = 0.5 * x - 1.5;
                y = Math.Round(y, 4);
                dataGridView1.Rows.Add(String.Format("{0:0.0}", x), String.Format("{0:0.0}", y));
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}

