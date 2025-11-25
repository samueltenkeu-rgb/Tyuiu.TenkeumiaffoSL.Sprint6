using System;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task6.V11.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        private string selectedFile = "";
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFile = ofd.FileName;
                textBoxIn.Text = System.IO.File.ReadAllText(selectedFile);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("Сначала выберите файл!", "Ошибка");
                return;
            }

            textBoxOut.Text = ds.CollectTextFromFile(selectedFile);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 6 | Вариант 11 | Автор: Тенкеумьяффо С.Л.");
        }
    }
}
