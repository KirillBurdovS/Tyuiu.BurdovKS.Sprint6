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
            groupBoxTask_BKS = new GroupBox();
            textBoxTask_BKS = new TextBox();
            groupBoxData_BKS = new GroupBox();
            dataGridViewLn = new DataGridView();
            groupBoxRes_BKS = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialog = new OpenFileDialog();
            buttonOpen_BKS = new Button();
            buttonSave_BKS = new Button();
            buttonHelp_BKS = new Button();
            buttonDone_BKS = new Button();
            saveFileDialog = new SaveFileDialog();
            groupBoxTask_BKS.SuspendLayout();
            groupBoxData_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLn).BeginInit();
            groupBoxRes_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(textBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(12, 94);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(763, 109);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // textBoxTask_BKS
            // 
            textBoxTask_BKS.BackColor = SystemColors.Menu;
            textBoxTask_BKS.BorderStyle = BorderStyle.None;
            textBoxTask_BKS.Location = new Point(0, 22);
            textBoxTask_BKS.Multiline = true;
            textBoxTask_BKS.Name = "textBoxTask_BKS";
            textBoxTask_BKS.Size = new Size(658, 81);
            textBoxTask_BKS.TabIndex = 0;
            textBoxTask_BKS.Text = "Дан файл InPutFileTask7V1.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить во втором столбце отрицательные значения на 1.";
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(dataGridViewLn);
            groupBoxData_BKS.Location = new Point(12, 209);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(439, 235);
            groupBoxData_BKS.TabIndex = 1;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод данных";
            // 
            // dataGridViewLn
            // 
            dataGridViewLn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLn.Location = new Point(6, 22);
            dataGridViewLn.Name = "dataGridViewLn";
            dataGridViewLn.Size = new Size(427, 207);
            dataGridViewLn.TabIndex = 0;
            // 
            // groupBoxRes_BKS
            // 
            groupBoxRes_BKS.Controls.Add(dataGridViewOut);
            groupBoxRes_BKS.Location = new Point(457, 209);
            groupBoxRes_BKS.Name = "groupBoxRes_BKS";
            groupBoxRes_BKS.Size = new Size(318, 235);
            groupBoxRes_BKS.TabIndex = 2;
            groupBoxRes_BKS.TabStop = false;
            groupBoxRes_BKS.Text = "Вывод данных";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(6, 22);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(306, 207);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // buttonOpen_BKS
            // 
            buttonOpen_BKS.Location = new Point(18, 23);
            buttonOpen_BKS.Name = "buttonOpen_BKS";
            buttonOpen_BKS.Size = new Size(75, 52);
            buttonOpen_BKS.TabIndex = 3;
            buttonOpen_BKS.Text = "Открыть";
            buttonOpen_BKS.UseVisualStyleBackColor = true;
            buttonOpen_BKS.Click += buttonOpen_BKS_Click;
            // 
            // buttonSave_BKS
            // 
            buttonSave_BKS.Location = new Point(180, 23);
            buttonSave_BKS.Name = "buttonSave_BKS";
            buttonSave_BKS.Size = new Size(75, 52);
            buttonSave_BKS.TabIndex = 4;
            buttonSave_BKS.Text = "Сохранить";
            buttonSave_BKS.UseVisualStyleBackColor = true;
            buttonSave_BKS.Click += buttonSave_BKS_Click;
            // 
            // buttonHelp_BKS
            // 
            buttonHelp_BKS.Location = new Point(666, 23);
            buttonHelp_BKS.Name = "buttonHelp_BKS";
            buttonHelp_BKS.Size = new Size(70, 52);
            buttonHelp_BKS.TabIndex = 5;
            buttonHelp_BKS.Text = "Справка";
            buttonHelp_BKS.UseVisualStyleBackColor = true;
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(99, 23);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(75, 52);
            buttonDone_BKS.TabIndex = 6;
            buttonDone_BKS.Text = "Получить";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 497);
            Controls.Add(buttonDone_BKS);
            Controls.Add(buttonHelp_BKS);
            Controls.Add(buttonSave_BKS);
            Controls.Add(buttonOpen_BKS);
            Controls.Add(groupBoxRes_BKS);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxTask_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 7 Вариант 1 СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            groupBoxTask_BKS.ResumeLayout(false);
            groupBoxTask_BKS.PerformLayout();
            groupBoxData_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLn).EndInit();
            groupBoxRes_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKS;
        private TextBox textBoxTask_BKS;
        private GroupBox groupBoxData_BKS;
        private DataGridView dataGridViewLn;
        private GroupBox groupBoxRes_BKS;
        private DataGridView dataGridViewOut;
        private OpenFileDialog openFileDialog;
        private Button buttonOpen_BKS;
        private Button buttonSave_BKS;
        private Button buttonHelp_BKS;
        private Button buttonDone_BKS;
        private SaveFileDialog saveFileDialog;
    }
}
