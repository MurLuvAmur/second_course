using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace csharp_5
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

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    // Чтение всего файла
                    string fileContent = File.ReadAllText(openFileDialog1.FileName, Encoding.GetEncoding(1251));

                    // Разделение на предложения (по знакам .!? с последующим пробелом или концом строки)
                    string[] sentences = System.Text.RegularExpressions.Regex.Split(
                        fileContent,
                        @"(?<=[.!?])\s+",
                        System.Text.RegularExpressions.RegexOptions.Multiline
                    );

                    // Оставляем только первые 3 предложения (если есть)
                    int count = Math.Min(3, sentences.Length);
                    string[] selectedSentences = new string[count];
                    Array.Copy(sentences, selectedSentences, count);

                    // Выводим в TextBox
                    textBox1.Text = string.Join(Environment.NewLine + Environment.NewLine, selectedSentences);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.GetEncoding(1251));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Разделение текста на предложения (по строкам)
            string[] sentences = textBox1.Text.Split(
                new[] { Environment.NewLine + Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries
            );

            // Проверяем, что есть хотя бы 3 предложения
            if (sentences.Length < 3)
            {
                MessageBox.Show("Файл должен содержать как минимум 3 предложения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Обратный порядок предложений
            Array.Reverse(sentences);

            // Объединяем обратно с двойными переводами строк
            textBox1.Text = string.Join(Environment.NewLine + Environment.NewLine, sentences);
        }
    }
}