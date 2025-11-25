using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task3.V16
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewResult;
        private Button buttonExecute;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTask = new Label();
            textBoxTask = new TextBox();
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();

            // labelTask
            labelTask.AutoSize = true;
            labelTask.Location = new Point(20, 20);
            labelTask.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelTask.Text = "Условие:";

            // textBoxTask
            textBoxTask.Location = new Point(20, 45);
            textBoxTask.Multiline = true;
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(400, 80);
            textBoxTask.Text =
                "Дан массив 5 на 5 элементов. Заменить четные значения\n" +
                "в третьей строке на 0.\n\n" +
                "Исходный массив:\n" +
                " 14   1  -3   1  10\n" +
                "  7  -3   5  -4   0\n" +
                "-10 -19 -18  -9  19\n" +
                " -2  -2 -16   2 -17\n" +
                "-16   9   5 -10  16";

            // dataGridViewResult
            dataGridViewResult.Location = new Point(20, 140);
            dataGridViewResult.Size = new Size(400, 150);
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.AllowUserToDeleteRows = false;

            // buttonExecute
            buttonExecute.Location = new Point(240, 300);
            buttonExecute.Size = new Size(90, 25);
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;

            // buttonInfo
            buttonInfo.Location = new Point(340, 300);
            buttonInfo.Size = new Size(30, 25);
            buttonInfo.Text = "?";
            buttonInfo.Click += buttonInfo_Click;

            // FormMain
            ClientSize = new Size(450, 340);
            Controls.Add(labelTask);
            Controls.Add(textBoxTask);
            Controls.Add(dataGridViewResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 3 | Тенкеумияффо С.Л. | Вариант 16";

            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
