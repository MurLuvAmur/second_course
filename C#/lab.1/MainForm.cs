using System;
using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class MainForm : Form
    {
        private double sideA, sideB, sideC;
        private bool calculatePerimeter, calculateArea;

        public MainForm()
        {
            InitializeComponent();
            Text = "Гусева Е.А. Группа ИСТ-23-2 Вариант 1";

            inputMenuItem.Click += InputMenuItem_Click;
            calcMenuItem.Click += CalcMenuItem_Click;
            exitMenuItem.Click += ExitMenuItem_Click;
        }

        private void InputMenuItem_Click(object sender, EventArgs e)
        {
            using (InputForm inputForm = new InputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    sideA = inputForm.SideA;
                    sideB = inputForm.SideB;
                    sideC = inputForm.SideC;
                    calculatePerimeter = inputForm.CalculatePerimeter;
                    calculateArea = inputForm.CalculateArea;
                }
            }
        }

        private void CalcMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (sideA == 0 || sideB == 0 || sideC == 0)
                    throw new InvalidOperationException("Сначала введите данные через меню Input!");

                if (!IsValidTriangle(sideA, sideB, sideC))
                    throw new InvalidOperationException("Треугольник с такими сторонами не существует!");

                double perimeter = calculatePerimeter ? sideA + sideB + sideC : 0;
                double area = 0;

                if (calculateArea)
                {
                    double p = (sideA + sideB + sideC) / 2;
                    area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                }

                using (ResultForm resultForm = new ResultForm(perimeter, area,
                       calculatePerimeter, calculateArea))
                {
                    resultForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}