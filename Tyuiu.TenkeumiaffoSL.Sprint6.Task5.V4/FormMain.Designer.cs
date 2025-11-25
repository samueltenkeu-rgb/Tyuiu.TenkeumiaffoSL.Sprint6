using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task5.V4
{
    partial class FormMain
    {
        private Button buttonLoad;
        private DataGridView dataGridViewValues;
        private PictureBox pictureBoxChart;
        private Label labelGrid;
        private Label labelChart;

        private void InitializeComponent()
        {
            this.buttonLoad = new Button();
            this.dataGridViewValues = new DataGridView();
            this.pictureBoxChart = new PictureBox();
            this.labelGrid = new Label();
            this.labelChart = new Label();

            // buttonLoad
            this.buttonLoad.Text = "Загрузить данные";
            this.buttonLoad.Location = new Point(20, 20);
            this.buttonLoad.Size = new Size(160, 30);
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // dataGridViewValues
            this.dataGridViewValues.Location = new Point(20, 80);
            this.dataGridViewValues.Size = new Size(260, 260);
            this.dataGridViewValues.ColumnCount = 1;
            this.dataGridViewValues.Columns[0].HeaderText = "Значения";

            // labelGrid
            this.labelGrid.Text = "Значения из файла";
            this.labelGrid.Location = new Point(20, 60);

            // pictureBoxChart
            this.pictureBoxChart.Location = new Point(320, 60);
            this.pictureBoxChart.Size = new Size(420, 280);
            this.pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxChart.Paint += new PaintEventHandler(this.pictureBoxChart_Paint);

            // labelChart
            this.labelChart.Text = "Диаграмма";
            this.labelChart.Location = new Point(320, 40);

            // FormMain
            this.ClientSize = new Size(760, 360);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.pictureBoxChart);
            this.Controls.Add(this.labelGrid);
            this.Controls.Add(this.labelChart);
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Тенкеумиаффо С.Л.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
    }
}
