

using Tyuiu.BurdovKS.Sprint6.Task7.V1.Lib;

using System.IO;
using System.Windows.Forms;

namespace Tyuiu.BurdovKS.Sprint6.Task7.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        static string path;
        static int coll;
        static int rows;
        public static int[,] mtr(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            coll = lines[0].Split(';').Length;


            int[,] arr = new int[rows, coll];
            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < coll; c++)
                {
                    arr[r, c] = Convert.ToInt32(linr[c]);
                }
            }
            return arr;
        }






        private void buttonOpen_BKS_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            int[,] arr = new int[rows, coll];
            arr = mtr(path);
            dataGridViewLn.ColumnCount = coll;
            dataGridViewOut.ColumnCount = coll;
            dataGridViewLn.RowCount = rows;
            dataGridViewOut.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridViewLn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < coll; c++)
                {
                    dataGridViewLn.Rows[r].Cells[c].Value = arr[r, c];
                }
            }
            buttonDone_BKS.Enabled = true;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {






        }

        private void buttonSave_BKS_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutTask7.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path1 = saveFileDialog.FileName;
            FileInfo fi = new FileInfo(path1);
            bool fe = fi.Exists;
            if (fe)
            {
                File.Delete(path1);
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    if (j != coll - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path1, str + Environment.NewLine);
                str = "";





            }
        }

        private void buttonDone_BKS_Click(object sender, EventArgs e)
        {

            int[,] arr = new int[rows, coll];
            arr = ds.GetMatrix(path);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < coll; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arr[r, c];
                }
            }
            buttonSave_BKS.Enabled = true;

        }
    }
}

