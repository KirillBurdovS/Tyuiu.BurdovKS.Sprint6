namespace Tyuiu.BurdovKS.Sprint6.Task4.V20
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_BKS = new GroupBox();
            pictureBoxTask_BKS = new PictureBox();
            groupBoxResult_BKS = new GroupBox();
            textBoxResult_BKS = new TextBox();
            groupBoxData_BKS = new GroupBox();
            textBoxStopData_BKS = new TextBox();
            textBoxStartData_BKS = new TextBox();
            textBoxStopStep_BKS = new TextBox();
            textBoxStartStep_BKS = new TextBox();
            buttonDone_BKS = new Button();
            buttonSave_BKS = new Button();
            groupBoxTask_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).BeginInit();
            groupBoxResult_BKS.SuspendLayout();
            groupBoxData_BKS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(pictureBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(20, 12);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(370, 161);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // pictureBoxTask_BKS
            // 
            pictureBoxTask_BKS.Image = (Image)resources.GetObject("pictureBoxTask_BKS.Image");
            pictureBoxTask_BKS.Location = new Point(0, 22);
            pictureBoxTask_BKS.Name = "pictureBoxTask_BKS";
            pictureBoxTask_BKS.Size = new Size(374, 82);
            pictureBoxTask_BKS.TabIndex = 0;
            pictureBoxTask_BKS.TabStop = false;
            // 
            // groupBoxResult_BKS
            // 
            groupBoxResult_BKS.Controls.Add(textBoxResult_BKS);
            groupBoxResult_BKS.Location = new Point(20, 170);
            groupBoxResult_BKS.Name = "groupBoxResult_BKS";
            groupBoxResult_BKS.Size = new Size(370, 268);
            groupBoxResult_BKS.TabIndex = 1;
            groupBoxResult_BKS.TabStop = false;
            groupBoxResult_BKS.Text = "Вывод данных";
            // 
            // textBoxResult_BKS
            // 
            textBoxResult_BKS.Location = new Point(6, 22);
            textBoxResult_BKS.Multiline = true;
            textBoxResult_BKS.Name = "textBoxResult_BKS";
            textBoxResult_BKS.Size = new Size(344, 240);
            textBoxResult_BKS.TabIndex = 0;
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(textBoxStopData_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStartData_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStopStep_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStartStep_BKS);
            groupBoxData_BKS.Location = new Point(428, 12);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(390, 161);
            groupBoxData_BKS.TabIndex = 2;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод данных";
            // 
            // textBoxStopData_BKS
            // 
            textBoxStopData_BKS.Location = new Point(196, 44);
            textBoxStopData_BKS.Name = "textBoxStopData_BKS";
            textBoxStopData_BKS.Size = new Size(100, 23);
            textBoxStopData_BKS.TabIndex = 3;
            // 
            // textBoxStartData_BKS
            // 
            textBoxStartData_BKS.Location = new Point(47, 44);
            textBoxStartData_BKS.Name = "textBoxStartData_BKS";
            textBoxStartData_BKS.Size = new Size(100, 23);
            textBoxStartData_BKS.TabIndex = 2;
            // 
            // textBoxStopStep_BKS
            // 
            textBoxStopStep_BKS.BackColor = SystemColors.Menu;
            textBoxStopStep_BKS.BorderStyle = BorderStyle.None;
            textBoxStopStep_BKS.Location = new Point(211, 22);
            textBoxStopStep_BKS.Name = "textBoxStopStep_BKS";
            textBoxStopStep_BKS.Size = new Size(100, 16);
            textBoxStopStep_BKS.TabIndex = 1;
            textBoxStopStep_BKS.Text = "Конец шага";
            // 
            // textBoxStartStep_BKS
            // 
            textBoxStartStep_BKS.BackColor = SystemColors.Menu;
            textBoxStartStep_BKS.BorderStyle = BorderStyle.None;
            textBoxStartStep_BKS.Location = new Point(62, 22);
            textBoxStartStep_BKS.Name = "textBoxStartStep_BKS";
            textBoxStartStep_BKS.Size = new Size(100, 16);
            textBoxStartStep_BKS.TabIndex = 0;
            textBoxStartStep_BKS.Text = "Старт шага";
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(824, 56);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(77, 60);
            buttonDone_BKS.TabIndex = 3;
            buttonDone_BKS.Text = "Выполнить";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // buttonSave_BKS
            // 
            buttonSave_BKS.Location = new Point(907, 56);
            buttonSave_BKS.Name = "buttonSave_BKS";
            buttonSave_BKS.Size = new Size(75, 60);
            buttonSave_BKS.TabIndex = 4;
            buttonSave_BKS.Text = "Сохранить";
            buttonSave_BKS.UseVisualStyleBackColor = true;
            buttonSave_BKS.Click += buttonSave_BKS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 450);
            Controls.Add(buttonSave_BKS);
            Controls.Add(buttonDone_BKS);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxResult_BKS);
            Controls.Add(groupBoxTask_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 4 Вариант 20 СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            groupBoxTask_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).EndInit();
            groupBoxResult_BKS.ResumeLayout(false);
            groupBoxResult_BKS.PerformLayout();
            groupBoxData_BKS.ResumeLayout(false);
            groupBoxData_BKS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxTask_BKS;
        private GroupBox groupBoxResult_BKS;
        private GroupBox groupBoxData_BKS;
        private PictureBox pictureBoxTask_BKS;
        private TextBox textBoxResult_BKS;
        private TextBox textBoxStopData_BKS;
        private TextBox textBoxStartData_BKS;
        private TextBox textBoxStopStep_BKS;
        private TextBox textBoxStartStep_BKS;
        private Button buttonDone_BKS;
        private Button buttonSave_BKS;
    }
}
