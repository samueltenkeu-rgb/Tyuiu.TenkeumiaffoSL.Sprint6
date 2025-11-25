using System;
using System.Windows.Forms;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task3.V16.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task3.V16
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
                int[,] matrix = new int[5, 5] {
                    { 14, 1, -3, 1, 10 },
                    { 7, -3, 5, -4, 0 },
                    { -10, -19, -18, -9, 19 },
                    { -2, -2, -16, 2, -17 },
                    { -16, 9, 5, -10, 16 }
                };

                int[,] result = ds.Calculate(matrix);

                dataGridViewResult.ColumnCount = 5;
                dataGridViewResult.RowCount = 5;
                dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < 5; i++)
                    dataGridViewResult.Columns[i].HeaderText = $"Столбец {i + 1}";

                for (int i = 0; i < 5; i++)
                {
                    dataGridViewResult.Rows[i].HeaderCell.Value = $"Строка {i + 1}";
                    for (int j = 0; j < 5; j++)
                        dataGridViewResult.Rows[i].Cells[j].Value = result[i, j];
                }

                dataGridViewResult.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Task 3 | Вариант 16 | Тенкеумияффо С.Л.",
                "О программе", MessageBoxButtons.OK);
        }
    }
}
