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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            f2.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide();
            f3.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Hide();
            f4.Show();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
