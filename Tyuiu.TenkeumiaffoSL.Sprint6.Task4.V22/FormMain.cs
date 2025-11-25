using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task4.V22.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task4.V22
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        double[] values = Array.Empty<double>();
        int start = -5, stop = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            values = ds.GetMassFunction(start, stop);

            // === вывод таблицы ===
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***************************");
            sb.AppendLine("*     x      *    f(x)    *");
            sb.AppendLine("***************************");

            for (int i = 0; i < values.Length; i++)
                sb.AppendLine($"*   {start + i,3}    *   {values[i],6:F2}   *");

            sb.AppendLine("***************************");
            textBoxResult.Text = sb.ToString();

            // перерисовать график
            pictureBoxChart.Refresh();
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (values.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int w = pictureBoxChart.Width - 40;
            int h = pictureBoxChart.Height - 40;

            // оси
            g.DrawLine(Pens.Black, 20, h / 2, w + 20, h / 2);
            g.DrawLine(Pens.Black, 20, 20, 20, h + 20);

            double min = double.MaxValue, max = double.MinValue;

            foreach (double v in values)
            {
                if (v < min) min = v;
                if (v > max) max = v;
            }

            if (max == min) max += 1;

            // масштаб
            double dx = w / (double)(values.Length - 1);
            double scaleY = h / (max - min);

            // рисуем линию
            for (int i = 0; i < values.Length - 1; i++)
            {
                float x1 = (float)(20 + i * dx);
                float x2 = (float)(20 + (i + 1) * dx);

                float y1 = (float)(20 + h - (values[i] - min) * scaleY);
                float y2 = (float)(20 + h - (values[i + 1] - min) * scaleY);

                g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // сохраняем текст
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V22.txt");
            File.WriteAllText(path, textBoxResult.Text);

            // сохраняем картинку
            string chartPath = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V22.png");
            pictureBoxChart.Image?.Save(chartPath);

            MessageBox.Show($"Файлы сохранены:\n{path}\n{chartPath}", "Готово");
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 — Task 4 — Вариант 22\nАвтор: Тенкеумьяффо С.Л.", "Информация");
        }
    }
}
