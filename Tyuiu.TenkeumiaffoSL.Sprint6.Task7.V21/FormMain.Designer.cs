using System.Windows.Forms;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task7.V21
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private Button buttonOpen;
        private Button buttonProcess;
        private Button buttonInfo;
        private Label labelIn;
        private Label labelOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewIn = new DataGridView();
            this.dataGridViewOut = new DataGridView();
            this.buttonOpen = new Button();
            this.buttonProcess = new Button();
            this.buttonInfo = new Button();
            this.labelIn = new Label();
            this.labelOut = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();

            // dataGridViewIn
            this.dataGridViewIn.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewIn.Size = new System.Drawing.Size(350, 260);

            // dataGridViewOut
            this.dataGridViewOut.Location = new System.Drawing.Point(400, 60);
            this.dataGridViewOut.Size = new System.Drawing.Size(350, 260);

            // buttonOpen
            this.buttonOpen.Location = new System.Drawing.Point(20, 20);
            this.buttonOpen.Size = new System.Drawing.Size(140, 30);
            this.buttonOpen.Text = "Выбрать файл";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);

            // buttonProcess
            this.buttonProcess.Location = new System.Drawing.Point(180, 20);
            this.buttonProcess.Size = new System.Drawing.Size(140, 30);
            this.buttonProcess.Text = "Обработать";
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);

            // buttonInfo
            this.buttonInfo.Location = new System.Drawing.Point(750, 20);
            this.buttonInfo.Size = new System.Drawing.Size(30, 30);
            this.buttonInfo.Text = "?";
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);

            // labelIn
            this.labelIn.Location = new System.Drawing.Point(20, 40);
            this.labelIn.AutoSize = true;
            this.labelIn.Text = "Входная матрица";

            // labelOut
            this.labelOut.Location = new System.Drawing.Point(400, 40);
            this.labelOut.AutoSize = true;
            this.labelOut.Text = "Результат";

            // FormMain
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dataGridViewIn);
            this.Controls.Add(this.dataGridViewOut);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 21 | Тенкеумьяффо С.Л.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
