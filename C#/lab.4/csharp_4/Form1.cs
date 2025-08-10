using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Создание массива
            int n = Convert.ToInt32(textBox1.Text);
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = 1;

            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                dataGridView1[i, 0].Value = Math.Round((rand.Next(-100, 100) + rand.NextDouble()), 1);
            }
            button2.Enabled = true;
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            // Обработка массива
            int n = Convert.ToInt32(textBox1.Text);
            double[] a = new double[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(dataGridView1[i, 0].Value);
            }

            // 1. Сумма отрицательных элементов
            double negativeSum = a.Where(x => x < 0).Sum();
            label3.Text = negativeSum.ToString("F2");

            // 2. Произведение между min и max элементами
            int minIndex = Array.IndexOf(a, a.Min());
            int maxIndex = Array.IndexOf(a, a.Max());

            double product = 1;
            int start = Math.Min(minIndex, maxIndex) + 1;
            int end = Math.Max(minIndex, maxIndex);

            if (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    product *= a[i];
                }
                label5.Text = product.ToString("F2");
            }
            else
            {
                label5.Text = "Нет элементов между min и max";
            }

            // 3. Сортировка массива
            Array.Sort(a);
            dataGridView2.ColumnCount = n;
            dataGridView2.RowCount = 1;

            for (int i = 0; i < n; i++)
            {
                dataGridView2.Columns[i].Width = 50;
                dataGridView2[i, 0].Value = a[i].ToString("F1");
            }
        }
    }
}
