using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task1.V11.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task1.V11
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

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

                double[] results = ds.GetMassFunction(start, stop);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("***************************");
                sb.AppendLine("*     x      *    f(x)    *");
                sb.AppendLine("***************************");

                for (int i = 0; i < results.Length; i++)
                {
                    sb.AppendLine($"*   {start + i,3}    *  {results[i],8:F2}  *");
                }

                sb.AppendLine("***************************");

                textBoxResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 1 Sprint 6, Вариант 11 выполнен студентом Миаффо Тенкеу Лоик Сэмюэль",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
