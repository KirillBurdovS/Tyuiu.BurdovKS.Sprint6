namespace Tyuiu.BurdovKS.Sprint6.Task6.V25
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
            textBoxEz_BKS = new TextBox();
            groupBoxData_BKS = new GroupBox();
            textBoxLn = new TextBox();
            groupBoxRes_BKS = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialog = new OpenFileDialog();
            groupBoxFile_BKS = new GroupBox();
            buttonToDo_BKS = new Button();
            buttonOpenFile_BKS = new Button();
            groupBoxTask_BKS.SuspendLayout();
            groupBoxData_BKS.SuspendLayout();
            groupBoxRes_BKS.SuspendLayout();
            groupBoxFile_BKS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKS
            // 
            groupBoxTask_BKS.Controls.Add(textBoxEz_BKS);
            groupBoxTask_BKS.Location = new Point(12, 97);
            groupBoxTask_BKS.Name = "groupBoxTask_BKS";
            groupBoxTask_BKS.Size = new Size(776, 77);
            groupBoxTask_BKS.TabIndex = 0;
            groupBoxTask_BKS.TabStop = false;
            groupBoxTask_BKS.Text = "Условие";
            // 
            // textBoxEz_BKS
            // 
            textBoxEz_BKS.BackColor = SystemColors.Menu;
            textBoxEz_BKS.BorderStyle = BorderStyle.None;
            textBoxEz_BKS.Location = new Point(10, 20);
            textBoxEz_BKS.Multiline = true;
            textBoxEz_BKS.Name = "textBoxEz_BKS";
            textBoxEz_BKS.Size = new Size(760, 51);
            textBoxEz_BKS.TabIndex = 0;
            textBoxEz_BKS.Text = resources.GetString("textBoxEz_BKS.Text");
            // 
            // groupBoxData_BKS
            // 
            groupBoxData_BKS.Controls.Add(textBoxLn);
            groupBoxData_BKS.Location = new Point(12, 180);
            groupBoxData_BKS.Name = "groupBoxData_BKS";
            groupBoxData_BKS.Size = new Size(364, 265);
            groupBoxData_BKS.TabIndex = 1;
            groupBoxData_BKS.TabStop = false;
            groupBoxData_BKS.Text = "Ввод";
            // 
            // textBoxLn
            // 
            textBoxLn.Location = new Point(6, 22);
            textBoxLn.Multiline = true;
            textBoxLn.Name = "textBoxLn";
            textBoxLn.Size = new Size(352, 236);
            textBoxLn.TabIndex = 0;
            // 
            // groupBoxRes_BKS
            // 
            groupBoxRes_BKS.Controls.Add(textBoxOut);
            groupBoxRes_BKS.Location = new Point(382, 180);
            groupBoxRes_BKS.Name = "groupBoxRes_BKS";
            groupBoxRes_BKS.Size = new Size(406, 265);
            groupBoxRes_BKS.TabIndex = 2;
            groupBoxRes_BKS.TabStop = false;
            groupBoxRes_BKS.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(6, 22);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(394, 236);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBoxFile_BKS
            // 
            groupBoxFile_BKS.Controls.Add(buttonToDo_BKS);
            groupBoxFile_BKS.Controls.Add(buttonOpenFile_BKS);
            groupBoxFile_BKS.Location = new Point(12, 12);
            groupBoxFile_BKS.Name = "groupBoxFile_BKS";
            groupBoxFile_BKS.Size = new Size(776, 79);
            groupBoxFile_BKS.TabIndex = 3;
            groupBoxFile_BKS.TabStop = false;
            // 
            // buttonToDo_BKS
            // 
            buttonToDo_BKS.Location = new Point(110, 13);
            buttonToDo_BKS.Name = "buttonToDo_BKS";
            buttonToDo_BKS.Size = new Size(75, 51);
            buttonToDo_BKS.TabIndex = 1;
            buttonToDo_BKS.Text = "Загрузить";
            buttonToDo_BKS.UseVisualStyleBackColor = true;
            buttonToDo_BKS.Click += buttonToDo_BKS_Click;
            // 
            // buttonOpenFile_BKS
            // 
            buttonOpenFile_BKS.Location = new Point(19, 13);
            buttonOpenFile_BKS.Name = "buttonOpenFile_BKS";
            buttonOpenFile_BKS.Size = new Size(75, 51);
            buttonOpenFile_BKS.TabIndex = 0;
            buttonOpenFile_BKS.Text = "Выбрать файл";
            buttonOpenFile_BKS.UseVisualStyleBackColor = true;
            buttonOpenFile_BKS.Click += buttonOpenFile_BKS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxFile_BKS);
            Controls.Add(groupBoxRes_BKS);
            Controls.Add(groupBoxData_BKS);
            Controls.Add(groupBoxTask_BKS);
            Name = "Form1";
            Text = "Спринт 6 Таск 6 Вариант 25 СМАРТб 24-1 Бурдов Кирилл Сергеевич";
            groupBoxTask_BKS.ResumeLayout(false);
            groupBoxTask_BKS.PerformLayout();
            groupBoxData_BKS.ResumeLayout(false);
            groupBoxData_BKS.PerformLayout();
            groupBoxRes_BKS.ResumeLayout(false);
            groupBoxRes_BKS.PerformLayout();
            groupBoxFile_BKS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKS;
        private GroupBox groupBoxData_BKS;
        private TextBox textBoxLn;
        private GroupBox groupBoxRes_BKS;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialog;
        private GroupBox groupBoxFile_BKS;
        private Button buttonOpenFile_BKS;
        private Button buttonToDo_BKS;
        private TextBox textBoxEz_BKS;
    }
}
