




using Tyuiu.BurdovKS.Sprint6.Task1.V5.Lib;


namespace Tyuiu.BurdovKS.Sprint6.Task1.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_KFA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int startStep = Convert.ToInt32(textBoxStartValue_BKS.Text);
            int stopStep = Convert.ToInt32(textBoxStopValue_BKS.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            textBoxResult_BKS.Text = "";
            textBoxResult_BKS.AppendText("+---------+----------+" + Environment.NewLine); 
            textBoxResult_BKS.AppendText("+    X    +    Y     +" + Environment.NewLine);
            textBoxResult_BKS.AppendText("+---------+----------+" + Environment.NewLine);

            string strLine;
            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5:d}   |  {1, 5:f2}   | ", startStep, valueArray[i]);
                textBoxResult_BKS.AppendText(strLine + Environment.NewLine);
                startStep++;
            }

            textBoxResult_BKS.AppendText("+---------+----------+" + Environment.NewLine);
        }
    


        


            private void buttonResult_BKS_Click(object sender, EventArgs e)
            {

            

            }
        }
    } 

