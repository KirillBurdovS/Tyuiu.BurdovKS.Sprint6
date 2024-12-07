namespace Tyuiu.BurdovKS.Sprint6.Task1.V5
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
            groupBoxTask_BKS = new GroupBox();
            groupBoxData_BKS = new GroupBox();
            textBoxStopValue_BKS = new TextBox();
            textBoxStartValue_BKS = new TextBox();
            textBoxStopData_BKS = new TextBox();
            textBoxStartData_BKS = new TextBox();
            buttonResult_BKS = new Button();
            buttonQwe_BKS = new Button();
            groupBoxRes_BKS = new GroupBox();
            textBoxResult_BKS = new TextBox();
            textBoxRes_BKS = new TextBox();
            textBoxInfo_BKS = new TextBox();
            groupBoxTask_BKS.SuspendLayout();
            groupBoxData_BKS.SuspendLayout();
            groupBoxRes_BKS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(textBoxInfo_BKS);
            groupBoxTask_BKS.Location = new Point(22, 21);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(501, 242);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(textBoxStopValue_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStartValue_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStopData_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStartData_BKS);
            groupBoxData_BKS.Location = new Point(22, 291);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(326, 136);
            groupBoxData_BKS.TabIndex = 1;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод данных";
            // 
            // textBoxStopValue_BKS
            // 
            textBoxStopValue_BKS.Location = new Point(180, 44);
            textBoxStopValue_BKS.Name = "textBoxStopValue_BKS";
            textBoxStopValue_BKS.Size = new Size(100, 23);
            textBoxStopValue_BKS.TabIndex = 3;
            // 
            // textBoxStartValue_BKS
            // 
            textBoxStartValue_BKS.Location = new Point(37, 44);
            textBoxStartValue_BKS.Name = "textBoxStartValue_BKS";
            textBoxStartValue_BKS.Size = new Size(100, 23);
            textBoxStartValue_BKS.TabIndex = 2;
            // 
            // textBoxStopData_BKS
            // 
            textBoxStopData_BKS.BackColor = SystemColors.Menu;
            textBoxStopData_BKS.BorderStyle = BorderStyle.None;
            textBoxStopData_BKS.Location = new Point(180, 22);
            textBoxStopData_BKS.Name = "textBoxStopData_BKS";
            textBoxStopData_BKS.Size = new Size(100, 16);
            textBoxStopData_BKS.TabIndex = 1;
            textBoxStopData_BKS.Text = "Конец шага";
            // 
            // textBoxStartData_BKS
            // 
            textBoxStartData_BKS.BackColor = SystemColors.Menu;
            textBoxStartData_BKS.BorderStyle = BorderStyle.None;
            textBoxStartData_BKS.Location = new Point(57, 22);
            textBoxStartData_BKS.Name = "textBoxStartData_BKS";
            textBoxStartData_BKS.Size = new Size(100, 16);
            textBoxStartData_BKS.TabIndex = 0;
            textBoxStartData_BKS.Text = "Старт шага";
            // 
            // buttonResult_BKS
            // 
            buttonResult_BKS.Location = new Point(443, 364);
            buttonResult_BKS.Name = "buttonResult_BKS";
            buttonResult_BKS.Size = new Size(80, 63);
            buttonResult_BKS.TabIndex = 2;
            buttonResult_BKS.Text = "Выполнить";
            buttonResult_BKS.UseVisualStyleBackColor = true;
            buttonResult_BKS.Click += buttonResult_BKS_Click;
            // 
            // buttonQwe_BKS
            // 
            buttonQwe_BKS.Location = new Point(362, 364);
            buttonQwe_BKS.Name = "buttonQwe_BKS";
            buttonQwe_BKS.Size = new Size(75, 63);
            buttonQwe_BKS.TabIndex = 3;
            buttonQwe_BKS.Text = "Справка";
            buttonQwe_BKS.UseVisualStyleBackColor = true;
            // 
            // groupBoxRes_BKS
            // 
            groupBoxRes_BKS.Controls.Add(textBoxResult_BKS);
            groupBoxRes_BKS.Controls.Add(textBoxRes_BKS);
            groupBoxRes_BKS.Location = new Point(552, 21);
            groupBoxRes_BKS.Name = "groupBoxRes_BKS";
            groupBoxRes_BKS.Size = new Size(236, 406);
            groupBoxRes_BKS.TabIndex = 4;
            groupBoxRes_BKS.TabStop = false;
            groupBoxRes_BKS.Text = "Вывод данных";
            // 
            // textBoxResult_BKS
            // 
            textBoxResult_BKS.Location = new Point(5, 48);
            textBoxResult_BKS.Name = "textBoxResult_BKS";
            textBoxResult_BKS.ReadOnly = true;
            textBoxResult_BKS.Size = new Size(225, 23);
            textBoxResult_BKS.TabIndex = 1;
            // 
            // textBoxRes_BKS
            // 
            textBoxRes_BKS.BackColor = SystemColors.Menu;
            textBoxRes_BKS.BorderStyle = BorderStyle.None;
            textBoxRes_BKS.Location = new Point(6, 22);
            textBoxRes_BKS.Name = "textBoxRes_BKS";
            textBoxRes_BKS.Size = new Size(100, 16);
            textBoxRes_BKS.TabIndex = 0;
            textBoxRes_BKS.Text = "Результат";
            // 
            // textBoxInfo_BKS
            // 
            textBoxInfo_BKS.BackColor = SystemColors.Menu;
            textBoxInfo_BKS.BorderStyle = BorderStyle.None;
            textBoxInfo_BKS.Location = new Point(6, 22);
            textBoxInfo_BKS.Name = "textBoxInfo_BKS";
            textBoxInfo_BKS.Size = new Size(165, 16);
            textBoxInfo_BKS.TabIndex = 0;
            textBoxInfo_BKS.Text = "sin(x) + (cos(2x)/2) - 1,5x";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes_BKS);
            Controls.Add(buttonQwe_BKS);
            Controls.Add(buttonResult_BKS);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxTask_BKS);
            Name = "Form1";
            Text = "СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            groupBoxTask_BKS.ResumeLayout(false);
            groupBoxTask_BKS.PerformLayout();
            groupBoxData_BKS.ResumeLayout(false);
            groupBoxData_BKS.PerformLayout();
            groupBoxRes_BKS.ResumeLayout(false);
            groupBoxRes_BKS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKS;
        private GroupBox groupBoxData_BKS;
        private TextBox textBoxStopValue_BKS;
        private TextBox textBoxStartValue_BKS;
        private TextBox textBoxStopData_BKS;
        private TextBox textBoxStartData_BKS;
        private Button buttonResult_BKS;
        private Button buttonQwe_BKS;
        private GroupBox groupBoxRes_BKS;
        private TextBox textBoxRes_BKS;
        private TextBox textBoxResult_BKS;
        private TextBox textBoxInfo_BKS;
    }
}
