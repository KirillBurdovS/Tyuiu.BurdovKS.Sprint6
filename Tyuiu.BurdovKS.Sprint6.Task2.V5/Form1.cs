


using Tyuiu.BurdovKS.Sprint6.Task2.V5.Lib;


namespace Tyuiu.BurdovKS.Sprint6.Task2.V5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_BKS_Click(object sender, EventArgs e)
        {
            int startStep = Convert.ToInt32(textBoxStartStep_BKS.Text);
            int stopStep = Convert.ToInt32(textBoxStopStep_BKS.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            valueArray = ds.GetMassFunction(startStep, stopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewFunction_BKS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                startStep++;
            }
        }

        private void dataGridViewFunction_BKS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
