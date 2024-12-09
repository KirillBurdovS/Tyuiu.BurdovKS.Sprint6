namespace Tyuiu.BurdovKS.Sprint6.Task5.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartDiag_BKS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_BKS = new GroupBox();
            buttonQwe_BKS = new Button();
            buttonOpen_BKS = new Button();
            buttonDone_BKS = new Button();
            textBoxTask_BKS = new TextBox();
            groupBoxData_BKS = new GroupBox();
            dataGridViewNums_BKS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)chartDiag_BKS).BeginInit();
            groupBoxTask_BKS.SuspendLayout();
            groupBoxData_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_BKS).BeginInit();
            SuspendLayout();
            // 
            // chartDiag_BKS
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_BKS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_BKS.Legends.Add(legend1);
            chartDiag_BKS.Location = new Point(385, 131);
            chartDiag_BKS.Name = "chartDiag_BKS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_BKS.Series.Add(series1);
            chartDiag_BKS.Size = new Size(403, 300);
            chartDiag_BKS.TabIndex = 0;
            chartDiag_BKS.Text = "chart1";
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(buttonQwe_BKS);
            groupBoxTask_BKS.Controls.Add(buttonOpen_BKS);
            groupBoxTask_BKS.Controls.Add(buttonDone_BKS);
            groupBoxTask_BKS.Controls.Add(textBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(12, 12);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(776, 113);
            groupBoxTask_BKS.TabIndex = 1;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // buttonQwe_BKS
            // 
            buttonQwe_BKS.Location = new Point(685, 22);
            buttonQwe_BKS.Name = "buttonQwe_BKS";
            buttonQwe_BKS.Size = new Size(75, 54);
            buttonQwe_BKS.TabIndex = 3;
            buttonQwe_BKS.Text = "Справка";
            buttonQwe_BKS.UseVisualStyleBackColor = true;
            buttonQwe_BKS.Click += buttonQwe_BKS_Click;
            // 
            // buttonOpen_BKS
            // 
            buttonOpen_BKS.Location = new Point(604, 22);
            buttonOpen_BKS.Name = "buttonOpen_BKS";
            buttonOpen_BKS.Size = new Size(75, 54);
            buttonOpen_BKS.TabIndex = 2;
            buttonOpen_BKS.Text = "Открыть";
            buttonOpen_BKS.UseVisualStyleBackColor = true;
            buttonOpen_BKS.Click += buttonOpen_BKS_Click;
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(520, 22);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(78, 54);
            buttonDone_BKS.TabIndex = 1;
            buttonDone_BKS.Text = "Выполнить";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // textBoxTask_BKS
            // 
            textBoxTask_BKS.BackColor = SystemColors.Menu;
            textBoxTask_BKS.BorderStyle = BorderStyle.None;
            textBoxTask_BKS.Location = new Point(6, 22);
            textBoxTask_BKS.Multiline = true;
            textBoxTask_BKS.Name = "textBoxTask_BKS";
            textBoxTask_BKS.Size = new Size(319, 85);
            textBoxTask_BKS.TabIndex = 0;
            textBoxTask_BKS.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView. Дан список из чисел. Вывести все числа, не равные 0. Построить диаграмму по этим значениям.";
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(dataGridViewNums_BKS);
            groupBoxData_BKS.Location = new Point(12, 131);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(367, 307);
            groupBoxData_BKS.TabIndex = 2;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Вывод данных";
            // 
            // dataGridViewNums_BKS
            // 
            dataGridViewNums_BKS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_BKS.Location = new Point(6, 22);
            dataGridViewNums_BKS.Name = "dataGridViewNums_BKS";
            dataGridViewNums_BKS.Size = new Size(355, 278);
            dataGridViewNums_BKS.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxTask_BKS);
            Controls.Add(chartDiag_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 5 Варинат 25 СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            ((System.ComponentModel.ISupportInitialize)chartDiag_BKS).EndInit();
            groupBoxTask_BKS.ResumeLayout(false);
            groupBoxTask_BKS.PerformLayout();
            groupBoxData_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_BKS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_BKS;
        private GroupBox groupBoxTask_BKS;
        private Button buttonQwe_BKS;
        private Button buttonOpen_BKS;
        private Button buttonDone_BKS;
        private TextBox textBoxTask_BKS;
        private GroupBox groupBoxData_BKS;
        private DataGridView dataGridViewNums_BKS;
    }
}
