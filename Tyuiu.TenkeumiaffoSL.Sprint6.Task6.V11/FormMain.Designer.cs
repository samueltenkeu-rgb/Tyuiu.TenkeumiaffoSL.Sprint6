namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task6.V11
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // textBoxIn
            this.textBoxIn.Location = new System.Drawing.Point(20, 60);
            this.textBoxIn.Multiline = true;
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Size = new System.Drawing.Size(350, 260);
            this.textBoxIn.ReadOnly = true;

            // textBoxOut
            this.textBoxOut.Location = new System.Drawing.Point(400, 60);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(350, 260);
            this.textBoxOut.ReadOnly = true;

            // buttonOpen
            this.buttonOpen.Location = new System.Drawing.Point(20, 20);
            this.buttonOpen.Size = new System.Drawing.Size(140, 30);
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);

            // buttonProcess
            this.buttonProcess.Location = new System.Drawing.Point(180, 20);
            this.buttonProcess.Size = new System.Drawing.Size(140, 30);
            this.buttonProcess.Text = "Обработать";
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);

            // buttonInfo
            this.buttonInfo.Location = new System.Drawing.Point(760, 20);
            this.buttonInfo.Size = new System.Drawing.Size(30, 30);
            this.buttonInfo.Text = "?";
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);

            // labelIn
            this.labelIn.Location = new System.Drawing.Point(20, 40);
            this.labelIn.AutoSize = true;
            this.labelIn.Text = "Содержимое файла";

            // labelOut
            this.labelOut.Location = new System.Drawing.Point(400, 40);
            this.labelOut.AutoSize = true;
            this.labelOut.Text = "Предпоследние слова";

            // FormMain
            this.ClientSize = new System.Drawing.Size(820, 340);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 11 | Тенкеумьяффо С.Л.";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
