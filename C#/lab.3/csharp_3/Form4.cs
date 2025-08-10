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

        public static long Fact(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void ПускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            double xbeg = Convert.ToDouble(textBox1.Text), xend = Convert.ToDouble(textBox2.Text), dx = Convert.ToDouble(textBox3.Text), E = Convert.ToDouble(textBox4.Text);
            
            
            for (double x = xbeg; x <= xend; x += dx)
            {
                double s = 0;
                double element = 1;
                int n = 0;
                int el_kol = 0;
                while (Math.Abs(element) >= E)
                {
                    s += element;
                    n++;
                    el_kol++;
                    element = (Math.Pow((-1), n) * Math.Pow(x, n))/Fact(n);
                }
                // Добавление строки в таблицу
                dataGridView1.Rows.Add(
                    Math.Round(x, 4).ToString(),
                    Math.Round(s, 6).ToString(),
                    el_kol.ToString()
                );
            }
        }
    }
}
