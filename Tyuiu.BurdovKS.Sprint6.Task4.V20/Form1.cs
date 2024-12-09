
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
using Tyuiu.BurdovKS.Sprint6.Task4.V20.Lib;

namespace Tyuiu.BurdovKS.Sprint6.Task4.V20
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
            try
            {
                int startValue = Convert.ToInt32(textBoxStartData_BKS.Text);
                int stopValue = Convert.ToInt32(textBoxStopData_BKS.Text);

                double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_BKS.Text = ""; // ������� ��������� ���� ����� �������

                // ��������� ��������� ���� ������������
                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxResult_BKS.Text += valueArray[i].ToString("F2") + Environment.NewLine; // ��������� ������ �������� � ��������� ����, ����������� �� 2 ������ ����� �������
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("���! �� ����� ������������ ������. ����������, ������� ����� �����.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("���! �������� ����� ������� ������� ��� ������� ���������.", "������ ������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_BKS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V20.txt";
                File.WriteAllText(path, textBoxResult_BKS.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + " ������� �������!\n ������� ��� � ��������?", "��� ������ ����� ���������!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("��������� ���� ��� ���������� �����:( ���������� �����!", "�����������...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
