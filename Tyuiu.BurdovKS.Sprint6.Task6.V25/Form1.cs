


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BurdovKS.Sprint6.Task6.V25.Lib;

namespace Tyuiu.BurdovKS.Sprint6.Task6.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_BKS_Click(object sender, EventArgs e)
        {

            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            textBoxLn.Text = File.ReadAllText(openFilePath);
            groupBoxFile_BKS.Text = groupBoxFile_BKS.Text + " " + openFileDialog.FileName;
            buttonToDo_BKS.Enabled = true;
        }

        private void buttonToDo_BKS_Click(object sender, EventArgs e)
        {
           string strParameter = "";
           

           textBoxOut.Text = ds.CollectTextFromFile(strParameter, openFilePath);


        }
    }
}

