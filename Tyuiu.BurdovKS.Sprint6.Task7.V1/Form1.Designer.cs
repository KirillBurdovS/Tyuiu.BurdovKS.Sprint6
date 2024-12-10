namespace Tyuiu.BurdovKS.Sprint6.Task7.V1
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
            groupBoxData_BKS = new GroupBox();
            dataGridViewLn = new DataGridView();
            groupBoxRes_BKS = new GroupBox();
            dataGridViewOut = new DataGridView();
            buttonOpen_BKS = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            buttonDone_BKS = new Button();
            buttonSave_BKS = new Button();
            buttonHelp_BKS = new Button();
            groupBoxTask_BKS = new GroupBox();
            textBoxTask_BKS = new TextBox();
            groupBoxData_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLn).BeginInit();
            groupBoxRes_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            groupBoxTask_BKS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(dataGridViewLn);
            groupBoxData_BKS.Location = new Point(12, 214);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(376, 224);
            groupBoxData_BKS.TabIndex = 0;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод данных";
            groupBoxData_BKS.Enter += groupBox1_Enter;
            // 
            // dataGridViewLn
            // 
            dataGridViewLn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLn.Location = new Point(30, 54);
            dataGridViewLn.Name = "dataGridViewLn";
            dataGridViewLn.Size = new Size(240, 150);
            dataGridViewLn.TabIndex = 0;
            // 
            // groupBoxRes_BKS
            // 
            groupBoxRes_BKS.Controls.Add(dataGridViewOut);
            groupBoxRes_BKS.Location = new Point(394, 214);
            groupBoxRes_BKS.Name = "groupBoxRes_BKS";
            groupBoxRes_BKS.Size = new Size(394, 224);
            groupBoxRes_BKS.TabIndex = 1;
            groupBoxRes_BKS.TabStop = false;
            groupBoxRes_BKS.Text = "Вывод данных";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(47, 48);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(240, 150);
            dataGridViewOut.TabIndex = 0;
            // 
            // buttonOpen_BKS
            // 
            buttonOpen_BKS.Location = new Point(35, 24);
            buttonOpen_BKS.Name = "buttonOpen_BKS";
            buttonOpen_BKS.Size = new Size(75, 36);
            buttonOpen_BKS.TabIndex = 2;
            buttonOpen_BKS.Text = "Open";
            buttonOpen_BKS.UseVisualStyleBackColor = true;
            buttonOpen_BKS.Click += buttonOpen_BKS_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(134, 25);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(75, 35);
            buttonDone_BKS.TabIndex = 3;
            buttonDone_BKS.Text = "Done";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // buttonSave_BKS
            // 
            buttonSave_BKS.Location = new Point(233, 25);
            buttonSave_BKS.Name = "buttonSave_BKS";
            buttonSave_BKS.Size = new Size(75, 35);
            buttonSave_BKS.TabIndex = 4;
            buttonSave_BKS.Text = "Save";
            buttonSave_BKS.UseVisualStyleBackColor = true;
            buttonSave_BKS.Click += buttonSave_BKS_Click;
            // 
            // buttonHelp_BKS
            // 
            buttonHelp_BKS.Location = new Point(654, 24);
            buttonHelp_BKS.Name = "buttonHelp_BKS";
            buttonHelp_BKS.Size = new Size(75, 30);
            buttonHelp_BKS.TabIndex = 5;
            buttonHelp_BKS.Text = "Справка";
            buttonHelp_BKS.UseVisualStyleBackColor = true;
            buttonHelp_BKS.Click += buttonHelp_BKS_Click;
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(textBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(12, 80);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(776, 117);
            groupBoxTask_BKS.TabIndex = 6;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // textBoxTask_BKS
            // 
            textBoxTask_BKS.BackColor = SystemColors.Menu;
            textBoxTask_BKS.BorderStyle = BorderStyle.None;
            textBoxTask_BKS.Location = new Point(6, 22);
            textBoxTask_BKS.Multiline = true;
            textBoxTask_BKS.Name = "textBoxTask_BKS";
            textBoxTask_BKS.Size = new Size(725, 89);
            textBoxTask_BKS.TabIndex = 0;
            textBoxTask_BKS.Text = "Дан файл InPutFileTask7V1.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTask_BKS);
            Controls.Add(buttonHelp_BKS);
            Controls.Add(buttonSave_BKS);
            Controls.Add(buttonDone_BKS);
            Controls.Add(buttonOpen_BKS);
            Controls.Add(groupBoxRes_BKS);
            Controls.Add(groupBoxData_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 7 Вариант 1 СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            groupBoxData_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLn).EndInit();
            groupBoxRes_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            groupBoxTask_BKS.ResumeLayout(false);
            groupBoxTask_BKS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_BKS;
        private DataGridView dataGridViewLn;
        private GroupBox groupBoxRes_BKS;
        private Button buttonOpen_BKS;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private DataGridView dataGridViewOut;
        private Button buttonDone_BKS;
        private Button buttonSave_BKS;
        private Button buttonHelp_BKS;
        private GroupBox groupBoxTask_BKS;
        private TextBox textBoxTask_BKS;
    }
}
