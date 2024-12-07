


using Tyuiu.BurdovKS.Sprint6.Task0.V27.Lib;


namespace Tyuiu.BurdovKS.Sprint6.Task0.V27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BKS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_BKS.Text)));
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBoxVarX_BKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonResult_BKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб 24-1 Бурдов Кирилл Сергеевич");
        }


        
    }
}
