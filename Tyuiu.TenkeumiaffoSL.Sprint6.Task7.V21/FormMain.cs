using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task7.V21.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        string selectedPath = "";
        DataService ds = new DataService();
        int[,] matrix;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPath = ofd.FileName;
                matrix = ds.GetMatrix(selectedPath);
                dataGridViewIn.DataSource = ToDataTable(matrix);
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала выберите файл!");
                return;
            }

            int[,] resultMatrix = ds.ProcessMatrix(matrix);
            dataGridViewOut.DataSource = ToDataTable(resultMatrix);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
            sfd.FileName = "OutPutFileTask7.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ds.SaveMatrix(resultMatrix, sfd.FileName);
                MessageBox.Show("Файл сохранен: " + sfd.FileName);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7, Вариант 21 — выполнено студентом Тенкеумьяффо С.Л.", "Информация");
        }

        private DataTable ToDataTable(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            DataTable dt = new DataTable();
            for (int c = 0; c < cols; c++)
                dt.Columns.Add("Col" + (c + 1), typeof(int));

            for (int r = 0; r < rows; r++)
            {
                DataRow dr = dt.NewRow();
                for (int c = 0; c < cols; c++)
                    dr[c] = array[r, c];
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
