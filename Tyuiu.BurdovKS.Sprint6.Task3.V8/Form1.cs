



using Tyuiu.BurdovKS.Sprint6.Task3.V8.Lib;


namespace Tyuiu.BurdovKS.Sprint6.Task3.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
            {

            { -10, 10, -7, 19, 6 },
            { 15, -13, -19, 9, 1 },
            { -20, -15, -6, 8, -4 },
            { 10, 18, -5, 9, -6 },
            { 16, -10, 4, 15, 16 }

            };

        private void buttonDone_BKS_Click(object sender, EventArgs e)
        {

            textBoxRes_BKS.Text = Convert.ToString(ds.Calculate(matrix));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {



                dataGridViewTask_BKS.ColumnCount = 5;
                dataGridViewTask_BKS.RowCount = 5;
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewTask_BKS.Columns[i].Width = 25;

                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridViewTask_BKS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                    }

                }
            }
            catch
            {
                MessageBox.Show("???-?? ?? ??? ? ?????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonQwe_BKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб 24-1 Бурдов Кирилл Сергеевич", "?????????", MessageBoxButtons.OK);
        }
    }
}
