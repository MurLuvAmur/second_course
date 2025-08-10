using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class ResultForm : Form
    {
        public ResultForm(double perimeter, double area,
                         bool showPerimeter, bool showArea)
        {
            InitializeComponent();
            Text = "Гусева Е.А. Группа ИСТ-23-2 Вариант 1";

            perimeterLabel.Visible = showPerimeter;
            areaLabel.Visible = showArea;

            if (showPerimeter)
                perimeterLabel.Text = $"Периметр: {perimeter:F2}";
            if (showArea)
                areaLabel.Text = $"Площадь: {area:F2}";
        }
    }
}