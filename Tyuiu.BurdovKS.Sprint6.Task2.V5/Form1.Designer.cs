namespace Tyuiu.BurdovKS.Sprint6.Task2.V5
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
            groupBoxTask_BKS = new GroupBox();
            pictureBoxTask_BKS = new PictureBox();
            groupBoxData_BKS = new GroupBox();
            textBoxStopStep_BKS = new TextBox();
            textBoxStartStep_BKS = new TextBox();
            textBoxData_BKS = new TextBox();
            textBoxDataX_BKS = new TextBox();
            groupBoxResult_BKS = new GroupBox();
            dataGridViewFunction_BKS = new DataGridView();
            buttonQwe_BKS = new Button();
            buttonDone_BKS = new Button();
            groupBoxTask_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).BeginInit();
            groupBoxData_BKS.SuspendLayout();
            groupBoxResult_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BKS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(pictureBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(30, 27);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(434, 189);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // pictureBoxTask_BKS
            // 
            pictureBoxTask_BKS.Image = (Image)resources.GetObject("pictureBoxTask_BKS.Image");
            pictureBoxTask_BKS.Location = new Point(8, 39);
            pictureBoxTask_BKS.Name = "pictureBoxTask_BKS";
            pictureBoxTask_BKS.Size = new Size(366, 69);
            pictureBoxTask_BKS.TabIndex = 0;
            pictureBoxTask_BKS.TabStop = false;
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(textBoxStopStep_BKS);
            groupBoxData_BKS.Controls.Add(textBoxStartStep_BKS);
            groupBoxData_BKS.Controls.Add(textBoxData_BKS);
            groupBoxData_BKS.Controls.Add(textBoxDataX_BKS);
            groupBoxData_BKS.Location = new Point(30, 264);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(265, 143);
            groupBoxData_BKS.TabIndex = 1;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод данных";
            // 
            // textBoxStopStep_BKS
            // 
            textBoxStopStep_BKS.Location = new Point(132, 65);
            textBoxStopStep_BKS.Name = "textBoxStopStep_BKS";
            textBoxStopStep_BKS.Size = new Size(100, 23);
            textBoxStopStep_BKS.TabIndex = 3;
            // 
            // textBoxStartStep_BKS
            // 
            textBoxStartStep_BKS.Location = new Point(8, 64);
            textBoxStartStep_BKS.Name = "textBoxStartStep_BKS";
            textBoxStartStep_BKS.Size = new Size(100, 23);
            textBoxStartStep_BKS.TabIndex = 2;
            // 
            // textBoxData_BKS
            // 
            textBoxData_BKS.BackColor = SystemColors.Menu;
            textBoxData_BKS.BorderStyle = BorderStyle.None;
            textBoxData_BKS.Location = new Point(129, 22);
            textBoxData_BKS.Name = "textBoxData_BKS";
            textBoxData_BKS.Size = new Size(100, 16);
            textBoxData_BKS.TabIndex = 1;
            textBoxData_BKS.Text = "Конец шага";
            // 
            // textBoxDataX_BKS
            // 
            textBoxDataX_BKS.BackColor = SystemColors.Menu;
            textBoxDataX_BKS.BorderStyle = BorderStyle.None;
            textBoxDataX_BKS.Location = new Point(23, 22);
            textBoxDataX_BKS.Name = "textBoxDataX_BKS";
            textBoxDataX_BKS.Size = new Size(100, 16);
            textBoxDataX_BKS.TabIndex = 0;
            textBoxDataX_BKS.Text = "Старт шага";
            // 
            // groupBoxResult_BKS
            // 
            groupBoxResult_BKS.Controls.Add(dataGridViewFunction_BKS);
            groupBoxResult_BKS.Location = new Point(488, 27);
            groupBoxResult_BKS.Name = "groupBoxResult_BKS";
            groupBoxResult_BKS.Size = new Size(300, 380);
            groupBoxResult_BKS.TabIndex = 2;
            groupBoxResult_BKS.TabStop = false;
            groupBoxResult_BKS.Text = "Вывод";
            // 
            // dataGridViewFunction_BKS
            // 
            dataGridViewFunction_BKS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BKS.Location = new Point(14, 51);
            dataGridViewFunction_BKS.Name = "dataGridViewFunction_BKS";
            dataGridViewFunction_BKS.Size = new Size(240, 150);
            dataGridViewFunction_BKS.TabIndex = 0;
            dataGridViewFunction_BKS.CellContentClick += dataGridViewFunction_BKS_CellContentClick;
            // 
            // buttonQwe_BKS
            // 
            buttonQwe_BKS.Location = new Point(321, 350);
            buttonQwe_BKS.Name = "buttonQwe_BKS";
            buttonQwe_BKS.Size = new Size(67, 57);
            buttonQwe_BKS.TabIndex = 3;
            buttonQwe_BKS.Text = "Справка";
            buttonQwe_BKS.UseVisualStyleBackColor = true;
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(394, 350);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(88, 57);
            buttonDone_BKS.TabIndex = 4;
            buttonDone_BKS.Text = "Выполнить";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_BKS);
            Controls.Add(buttonQwe_BKS);
            Controls.Add(groupBoxResult_BKS);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxTask_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 2 Вариант5 Бурдов К.С";
            groupBoxTask_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).EndInit();
            groupBoxData_BKS.ResumeLayout(false);
            groupBoxData_BKS.PerformLayout();
            groupBoxResult_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BKS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKS;
        private GroupBox groupBoxData_BKS;
        private GroupBox groupBoxResult_BKS;
        private Button buttonQwe_BKS;
        private Button buttonDone_BKS;
        private PictureBox pictureBoxTask_BKS;
        private TextBox textBoxData_BKS;
        private TextBox textBoxDataX_BKS;
        private TextBox textBoxStopStep_BKS;
        private TextBox textBoxStartStep_BKS;
        private DataGridView dataGridViewFunction_BKS;
    }
}
