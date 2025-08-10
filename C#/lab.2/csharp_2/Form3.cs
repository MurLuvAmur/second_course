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
    public partial class Form3 : Form
    {
        public Form3()
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
            double x = Convert.ToDouble(textBox1.Text), y = 0;
            if (x > 9 || x < -9) label3.Text = "x вне предела";
            else
            {
                if (x >= -9 && x <= -6) y = -(Math.Sqrt(9 - (x+6)*(x+6)));
                else if (x >= -6 && x <= -3) y = x + 3;
                else if (x >= -3 && x <= 0) y = Math.Sqrt(9 - x * x);
                else if (x >= 0 && x <= 3) y = 3 - x ;
                else if (x >= 3 && x <= 9) y = 0.5*x - 1.5;
                y = Math.Round(y, 4);
                label3.Text = y.ToString();
            }
        }
    }
}
