using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task5.V4.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private double[] values = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Иван\source\repos\Tyuiu.TenkeumiaffoSL.Sprint6\Sprint6Task5\InPutFileTask5V4.txt";

                values = ds.LoadFromDataFile(path);

                dataGridViewValues.Rows.Clear();

                foreach (double v in values)
                    dataGridViewValues.Rows.Add(v);

                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (values.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int x = 20, y = 20;
            int barHeight = 20;
            int maxWidth = pictureBoxChart.Width - 60;

            double max = values.Max();
            if (max == 0) max = 1;

            foreach (double val in values)
            {
                int width = (int)((val / max) * maxWidth);
                g.FillRectangle(Brushes.LightBlue, x, y, width, barHeight);
                g.DrawRectangle(Pens.Black, x, y, width, barHeight);
                g.DrawString(val.ToString("0.###"), this.Font, Brushes.Black, x + width + 5, y);
                y += barHeight + 5;
            }
        }
    }
}
