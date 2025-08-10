using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace csharp_5
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

        private void Button1_Click(object sender, EventArgs e)
        {
            // Создание матрицы
            int rows = Convert.ToInt32(textBox1.Text);
            int cols = Convert.ToInt32(textBox2.Text);

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Width = 35;
            }

            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dataGridView1[j, i].Value = rand.Next(-25, 100);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = button1.Enabled;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(textBox1.Text);
                int cols = Convert.ToInt32(textBox2.Text);
                int[,] matrix = new int[rows, cols];

                // Заполнение матрицы из DataGridView
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < cols; j++)
                        matrix[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);

                // 1. Количество строк без нулей
                int rowsWithoutZero = 0;
                for (int i = 0; i < rows; i++)
                {
                    bool hasZero = false;
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            hasZero = true;
                            break;
                        }
                    }
                    if (!hasZero) rowsWithoutZero++;
                }

                // 2. Максимальное число, встречающееся более одного раза
                Dictionary<int, int> numberCounts = new Dictionary<int, int>();
                int maxRepeatedNumber = int.MinValue;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int num = matrix[i, j];
                        if (numberCounts.ContainsKey(num))
                        {
                            numberCounts[num]++;
                            if (num > maxRepeatedNumber && numberCounts[num] > 1)
                                maxRepeatedNumber = num;
                        }
                        else
                        {
                            numberCounts[num] = 1;
                        }
                    }
                }

                // Вывод результатов
                label3.Text = $"Строк без нулей: {rowsWithoutZero}";
                label4.Text = maxRepeatedNumber > int.MinValue
                    ? $"Макс. повторяющееся число: {maxRepeatedNumber}"
                    : "Повторяющихся чисел нет";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}