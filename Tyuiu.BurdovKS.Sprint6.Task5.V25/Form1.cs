


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BurdovKS.Sprint6.Task5.V25.Lib;


namespace Tyuiu.BurdovKS.Sprint6.Task5.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        //C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint6\Tyuiu.BurdovKS.Sprint6.Task5.V25\bin\Debug\net8.0-windows
        string path = @"C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint6\Tyuiu.BurdovKS.Sprint6.Task5.V25\bin\Debug\net8.0-windows\InPutFileTask5V25.txt";
        private void buttonDone_BKS_Click(object sender, EventArgs e)
        {

            dataGridViewNums_BKS.ColumnCount = 2;
            dataGridViewNums_BKS.Columns[0].Width = 20;
            dataGridViewNums_BKS.Columns[1].Width = 50;
            this.chartDiag_BKS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_BKS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_BKS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_BKS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_BKS.Series[0].Points.AddXY(i, numsMass[i]);
            }





        }

        private void buttonOpen_BKS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonQwe_BKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб 24-1 Бурдов Кирилл Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
