namespace Tyuiu.BurdovKS.Sprint6.Task0.V27
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
            textBoxVarX_BKS = new TextBox();
            textBoxData_BKS = new TextBox();
            groupBoxRes_BKS = new GroupBox();
            textBoxResult_BKS = new TextBox();
            textBoxRes_BKS = new TextBox();
            buttonResult_BKS = new Button();
            buttonQwe_BKS = new Button();
            groupBoxTask_BKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).BeginInit();
            groupBoxData_BKS.SuspendLayout();
            groupBoxRes_BKS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(pictureBoxTask_BKS);
            groupBoxTask_BKS.Location = new Point(12, 17);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(764, 174);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // pictureBoxTask_BKS
            // 
            pictureBoxTask_BKS.Image = (Image)resources.GetObject("pictureBoxTask_BKS.Image");
            pictureBoxTask_BKS.Location = new Point(284, 10);
            pictureBoxTask_BKS.Name = "pictureBoxTask_BKS";
            pictureBoxTask_BKS.Size = new Size(480, 103);
            pictureBoxTask_BKS.TabIndex = 0;
            pictureBoxTask_BKS.TabStop = false;
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(textBoxVarX_BKS);
            groupBoxData_BKS.Controls.Add(textBoxData_BKS);
            groupBoxData_BKS.Location = new Point(12, 234);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(303, 204);
            groupBoxData_BKS.TabIndex = 1;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод данных";
            // 
            // textBoxVarX_BKS
            // 
            textBoxVarX_BKS.Location = new Point(6, 44);
            textBoxVarX_BKS.Name = "textBoxVarX_BKS";
            textBoxVarX_BKS.Size = new Size(100, 23);
            textBoxVarX_BKS.TabIndex = 1;
            textBoxVarX_BKS.KeyPress += textBoxVarX_BKS_KeyPress;
            // 
            // textBoxData_BKS
            // 
            textBoxData_BKS.BackColor = SystemColors.Menu;
            textBoxData_BKS.BorderStyle = BorderStyle.None;
            textBoxData_BKS.Location = new Point(6, 22);
            textBoxData_BKS.Name = "textBoxData_BKS";
            textBoxData_BKS.Size = new Size(100, 16);
            textBoxData_BKS.TabIndex = 0;
            textBoxData_BKS.Text = "Переменная X";
            // 
            // groupBoxRes_BKS
            // 
            groupBoxRes_BKS.Controls.Add(textBoxResult_BKS);
            groupBoxRes_BKS.Controls.Add(textBoxRes_BKS);
            groupBoxRes_BKS.Location = new Point(382, 241);
            groupBoxRes_BKS.Name = "groupBoxRes_BKS";
            groupBoxRes_BKS.Size = new Size(394, 133);
            groupBoxRes_BKS.TabIndex = 2;
            groupBoxRes_BKS.TabStop = false;
            groupBoxRes_BKS.Text = "Вывод данных";
            // 
            // textBoxResult_BKS
            // 
            textBoxResult_BKS.Location = new Point(12, 66);
            textBoxResult_BKS.Name = "textBoxResult_BKS";
            textBoxResult_BKS.ReadOnly = true;
            textBoxResult_BKS.Size = new Size(100, 23);
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
            // buttonResult_BKS
            // 
            buttonResult_BKS.Location = new Point(666, 394);
            buttonResult_BKS.Name = "buttonResult_BKS";
            buttonResult_BKS.Size = new Size(110, 44);
            buttonResult_BKS.TabIndex = 3;
            buttonResult_BKS.Text = "Выполнить";
            buttonResult_BKS.UseVisualStyleBackColor = true;
            buttonResult_BKS.Click += buttonResult_BKS_Click;
            // 
            // buttonQwe_BKS
            // 
            buttonQwe_BKS.Location = new Point(581, 394);
            buttonQwe_BKS.Name = "buttonQwe_BKS";
            buttonQwe_BKS.Size = new Size(75, 44);
            buttonQwe_BKS.TabIndex = 4;
            buttonQwe_BKS.Text = "?";
            buttonQwe_BKS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonQwe_BKS);
            Controls.Add(buttonResult_BKS);
            Controls.Add(groupBoxRes_BKS);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxTask_BKS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "СМАРТб 24-1 Бурдов К.С";
            groupBoxTask_BKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKS).EndInit();
            groupBoxData_BKS.ResumeLayout(false);
            groupBoxData_BKS.PerformLayout();
            groupBoxRes_BKS.ResumeLayout(false);
            groupBoxRes_BKS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKS;
        private PictureBox pictureBoxTask_BKS;
        private GroupBox groupBoxData_BKS;
        private TextBox textBoxVarX_BKS;
        private TextBox textBoxData_BKS;
        private GroupBox groupBoxRes_BKS;
        private TextBox textBoxResult_BKS;
        private TextBox textBoxRes_BKS;
        private Button buttonResult_BKS;
        private Button buttonQwe_BKS;
    }
}
