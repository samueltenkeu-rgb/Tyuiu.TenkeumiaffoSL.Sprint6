using System;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task2.V18.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task2.V18
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int start = -5;
                int stop = 5;

                double[] result = ds.GetMassFunction(start, stop);

                dataGridViewResult.Rows.Clear();
                dataGridViewResult.Columns.Clear();

                dataGridViewResult.Columns.Add("colX", "X");
                dataGridViewResult.Columns.Add("colFX", "f(x)");

                for (int i = 0; i < result.Length; i++)
                {
                    dataGridViewResult.Rows.Add(start + i, result[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 2 | Вариант 18 | Тенкеумияффо С.Л.",
                            "О программе", MessageBoxButtons.OK);
        }
    }
}
