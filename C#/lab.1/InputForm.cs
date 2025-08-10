using System;
using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class InputForm : Form
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public bool CalculatePerimeter { get; private set; }
        public bool CalculateArea { get; private set; }

        public InputForm()
        {
            InitializeComponent();
            Text = "Гусева Е.А. Группа ИСТ-23-2 Вариант 1";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                SideA = double.Parse(sideATextBox.Text);
                SideB = double.Parse(sideBTextBox.Text);
                SideC = double.Parse(sideCTextBox.Text);

                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                    throw new ArgumentException("Стороны должны быть положительными!");

                if (!(SideA + SideB > SideC &&
                      SideA + SideC > SideB &&
                      SideB + SideC > SideA))
                    throw new ArgumentException("Невозможно построить треугольник с такими сторонами!");

                if (!perimeterCheckBox.Checked && !areaCheckBox.Checked)
                    throw new ArgumentException("Выберите хотя бы один параметр для расчета!");

                CalculatePerimeter = perimeterCheckBox.Checked;
                CalculateArea = areaCheckBox.Checked;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числовые значения для всех сторон!",
                                "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}