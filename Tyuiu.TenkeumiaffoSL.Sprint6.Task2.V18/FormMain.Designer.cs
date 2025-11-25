using System;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task2.V18
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFormula;
        private DataGridView dataGridViewResult;
        private Button buttonExecute;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBoxFormula = new PictureBox();
            dataGridViewResult = new DataGridView();
            buttonExecute = new Button();
            buttonInfo = new Button();

            SuspendLayout();

            // pictureBoxFormula
            string username = Environment.UserName;
            string imgPath = Path.Combine($"C:\\Users\\{username}",
                "source", "repos", "Tyuiu.TenkeumiaffoSL.Sprint6", "img", "task2.png");

            pictureBoxFormula.ImageLocation = imgPath;
            pictureBoxFormula.Location = new Point(20, 20);
            pictureBoxFormula.Size = new Size(400, 50);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;

            // dataGridViewResult
            dataGridViewResult.Location = new Point(20, 90);
            dataGridViewResult.Size = new Size(400, 200);
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;

            // buttonExecute
            buttonExecute.Text = "Выполнить";
            buttonExecute.Location = new Point(240, 300);
            buttonExecute.Size = new Size(90, 25);
            buttonExecute.Click += buttonExecute_Click;

            // buttonInfo
            buttonInfo.Text = "?";
            buttonInfo.Location = new Point(340, 300);
            buttonInfo.Size = new Size(30, 25);
            buttonInfo.Click += buttonInfo_Click;

            // FormMain
            ClientSize = new Size(450, 350);
            Controls.Add(pictureBoxFormula);
            Controls.Add(dataGridViewResult);
            Controls.Add(buttonExecute);
            Controls.Add(buttonInfo);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 2 | Тенкеумияффо С.Л. | Вариант 18";

            ResumeLayout(false);
        }
    }
}
