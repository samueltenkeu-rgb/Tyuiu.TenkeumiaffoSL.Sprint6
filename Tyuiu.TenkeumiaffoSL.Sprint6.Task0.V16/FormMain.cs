using System;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task0.V16.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task0.V16
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
                int x = 3;
                double result = ds.Calculate(x);
                textBoxResult.Text = $"Результат при x = {x}: {result:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Sprint6, вариант 16 выполнен студентом Миаффо Тенкеу Лоик Сэмюэль",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
