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
    public partial class Form2 : Form
    {
        public Form2()
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
            string textbox = Convert.ToString(textBox1.Text);
            int n;
            bool isdigit = int.TryParse(textbox, out n);
            if (isdigit == false) label2.Text = "Ошибка!";
            else
            {
                if (n < 0) label2.Text = "Ошибка!";
                if (n >= 100) n = n % 100;
                if (n >= 20) n = n % 10;
                if (n >= 10 && n <= 19 || n == 0 || n >= 5 && n <= 9) label2.Text = "Рублей";
                else if (n >= 2 && n <= 4) label2.Text = "Рубля";
                else if (n == 1) label2.Text = "Рубль";
            }
        }
    }
}
