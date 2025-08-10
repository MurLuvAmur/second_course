using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace MetodGaussa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            panelMatrix.Controls.Clear();

            int rows = (int)numEquations.Value;
            int cols = (int)numVariables.Value + 1; // +1 для свободных членов
            int cellSize = 50; 

            // Создаем таблицу для матрицы
            TableLayoutPanel table = new TableLayoutPanel();
            table.ColumnCount = cols + 1; // +1 для подписей строк
            table.RowCount = rows + 1;    // +1 для заголовков столбцов
            table.AutoSize = true;
            table.AutoScroll = false;
            table.AutoSize = false;

            // Рассчитываем точные размеры
            int tableWidth = cellSize + cols * cellSize;
            int tableHeight = cellSize + rows * cellSize;
            table.Size = new Size(tableWidth, tableHeight);

            // Настройка стилей столбцов и строк
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellSize));
            for (int i = 0; i < cols; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellSize));
            }

            table.RowStyles.Add(new RowStyle(SizeType.Absolute, cellSize));
            for (int i = 0; i < rows; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, cellSize/2));
            }

            // Заголовки столбцов
            for (int c = 0; c < cols; c++)
            {
                Label header = new Label();
                header.Text = c < cols - 1 ? $"X{c + 1}" : "Св.чл.";
                header.Size = new Size(cellSize, cellSize);
                header.TextAlign = ContentAlignment.MiddleCenter;
                header.BackColor = Color.LightGray;
                table.Controls.Add(header, c + 1, 0);
            }

            // Заполняем матрицу
            for (int r = 0; r < rows; r++)
            {
                // Подпись строки
                Label rowLabel = new Label();
                rowLabel.Text = $"Ур.{r + 1}";
                rowLabel.TextAlign = ContentAlignment.MiddleRight;
                table.Controls.Add(rowLabel, 0, r + 1);

                // Поля ввода
                for (int c = 0; c < cols; c++)
                {
                    TextBox tb = new TextBox();
                    tb.Size = new Size(cellSize, cellSize);
                    tb.TextAlign = HorizontalAlignment.Center;
                    if (c == cols - 1) tb.BackColor = Color.LightCyan;
                    table.Controls.Add(tb, c + 1, r + 1);
                }
            }

            panelMatrix.Controls.Add(table);

            panelMatrix.AutoScroll = false;
            panelMatrix.AutoSize = false;
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = (int)numEquations.Value;
                int cols = (int)numVariables.Value + 1;
                double[,] matrix = new double[rows, cols];

                // Получаем данные из текстовых полей
                TableLayoutPanel table = (TableLayoutPanel)panelMatrix.Controls[0];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Control control = table.GetControlFromPosition(c + 1, r + 1);
                        if (control is TextBox tb)
                        {
                            if (string.IsNullOrEmpty(tb.Text))
                            {
                                txtResult.Text = $"Ошибка: не введено значение в строке {r + 1}, столбце {c + 1}";
                                return;
                            }

                            if (!double.TryParse(tb.Text, out matrix[r, c]))
                            {
                                txtResult.Text = $"Ошибка: некорректное значение в строке {r + 1}, столбце {c + 1}";
                                return;
                            }
                        }
                    }
                }

                // Решаем систему
                double[] solution = SolveSystem(matrix);

                // Выводим результат
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < solution.Length; i++)
                {
                    sb.AppendLine($"x{i + 1} = {solution[i]:F4}");
                }
                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                txtResult.Text = "Ошибка: " + ex.Message;
            }
        }

        private double[] SolveSystem(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int vars = cols - 1;

            // Прямой ход метода Гаусса
            for (int i = 0; i < rows; i++)
            {
                // Ищем строку с максимальным элементом в текущем столбце
                int maxRow = i;
                for (int k = i + 1; k < rows; k++)
                {
                    if (Math.Abs(matrix[k, i]) > Math.Abs(matrix[maxRow, i]))
                    {
                        maxRow = k;
                    }
                }

                // Меняем строки местами
                if (maxRow != i)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        double temp = matrix[i, j];
                        matrix[i, j] = matrix[maxRow, j];
                        matrix[maxRow, j] = temp;
                    }
                }

                // Делаем диагональный элемент равным 1
                double div = matrix[i, i];
                if (Math.Abs(div) < 0.00001)
                {
                    throw new Exception("Система не имеет решения или имеет бесконечно много решений");
                }

                for (int j = i; j < cols; j++)
                {
                    matrix[i, j] /= div;
                }

                // Обнуляем элементы ниже
                for (int k = i + 1; k < rows; k++)
                {
                    double factor = matrix[k, i];
                    for (int j = i; j < cols; j++)
                    {
                        matrix[k, j] -= factor * matrix[i, j];
                    }
                }
            }

            // Обратный ход
            double[] solution = new double[vars];
            for (int i = vars - 1; i >= 0; i--)
            {
                solution[i] = matrix[i, vars];
                for (int j = i + 1; j < vars; j++)
                {
                    solution[i] -= matrix[i, j] * solution[j];
                }
            }

            return solution;
        }
    }
}