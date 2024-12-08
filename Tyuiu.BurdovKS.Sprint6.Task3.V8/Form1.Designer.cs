namespace Tyuiu.BurdovKS.Sprint6.Task3.V8
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
            dataGridViewTask_BKS = new DataGridView();
            pictureBoxTask_BKS = new PictureBox();
            groupBoxRes_BKS = new GroupBox();
            buttonQwe_BKS = new Button();
            buttonDone_BKS = new Button();
            textBoxRes_BKS = new TextBox();
            textBoxData_BKS = new TextBox();
            groupBoxTask_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_BKS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).BeginInit();
            groupBoxRes_BKS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(dataGridViewTask_BKS);
            groupBoxTask_BKS.Controls.Add(pictureBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(12, 12);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(450, 426);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // dataGridViewTask_BKS
            // 
            dataGridViewTask_BKS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_BKS.Location = new Point(198, 22);
            dataGridViewTask_BKS.Name = "dataGridViewTask_BKS";
            dataGridViewTask_BKS.Size = new Size(240, 263);
            dataGridViewTask_BKS.TabIndex = 1;
            // 
            // pictureBoxTask_BKS
            // 
            pictureBoxTask_BKS.Image = (Image)resources.GetObject("pictureBoxTask_BKS.Image");
            pictureBoxTask_BKS.Location = new Point(0, 22);
            pictureBoxTask_BKS.Name = "pictureBoxTask_BKS";
            pictureBoxTask_BKS.Size = new Size(178, 263);
            pictureBoxTask_BKS.TabIndex = 0;
            pictureBoxTask_BKS.TabStop = false;
            // 
            // groupBoxRes_BKS
            // 
            groupBoxRes_BKS.Controls.Add(buttonQwe_BKS);
            groupBoxRes_BKS.Controls.Add(buttonDone_BKS);
            groupBoxRes_BKS.Controls.Add(textBoxRes_BKS);
            groupBoxRes_BKS.Controls.Add(textBoxData_BKS);
            groupBoxRes_BKS.Location = new Point(490, 12);
            groupBoxRes_BKS.Name = "groupBoxRes_BKS";
            groupBoxRes_BKS.Size = new Size(288, 426);
            groupBoxRes_BKS.TabIndex = 1;
            groupBoxRes_BKS.TabStop = false;
            groupBoxRes_BKS.Text = "Вывод данных";
            // 
            // buttonQwe_BKS
            // 
            buttonQwe_BKS.Location = new Point(112, 363);
            buttonQwe_BKS.Name = "buttonQwe_BKS";
            buttonQwe_BKS.Size = new Size(70, 57);
            buttonQwe_BKS.TabIndex = 3;
            buttonQwe_BKS.Text = "?";
            buttonQwe_BKS.UseVisualStyleBackColor = true;
            buttonQwe_BKS.Click += buttonQwe_BKS_Click;
            // 
            // buttonDone_BKS
            // 
            buttonDone_BKS.Location = new Point(200, 363);
            buttonDone_BKS.Name = "buttonDone_BKS";
            buttonDone_BKS.Size = new Size(82, 57);
            buttonDone_BKS.TabIndex = 2;
            buttonDone_BKS.Text = "Выполнить";
            buttonDone_BKS.UseVisualStyleBackColor = true;
            buttonDone_BKS.Click += buttonDone_BKS_Click;
            // 
            // textBoxRes_BKS
            // 
            textBoxRes_BKS.Location = new Point(6, 44);
            textBoxRes_BKS.Name = "textBoxRes_BKS";
            textBoxRes_BKS.Size = new Size(100, 23);
            textBoxRes_BKS.TabIndex = 1;
            // 
            // textBoxData_BKS
            // 
            textBoxData_BKS.BackColor = SystemColors.Menu;
            textBoxData_BKS.BorderStyle = BorderStyle.None;
            textBoxData_BKS.Location = new Point(6, 22);
            textBoxData_BKS.Name = "textBoxData_BKS";
            textBoxData_BKS.Size = new Size(100, 16);
            textBoxData_BKS.TabIndex = 0;
            textBoxData_BKS.Text = "Результат";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes_BKS);
            Controls.Add(groupBoxTask_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 3 Вариант 8 СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            Load += Form1_Load;
            groupBoxTask_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_BKS).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).EndInit();
            groupBoxRes_BKS.ResumeLayout(false);
            groupBoxRes_BKS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKS;
        private PictureBox pictureBoxTask_BKS;
        private GroupBox groupBoxRes_BKS;
        private DataGridView dataGridViewTask_BKS;
        private Button buttonQwe_BKS;
        private Button buttonDone_BKS;
        private TextBox textBoxRes_BKS;
        private TextBox textBoxData_BKS;
    }
}
