using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint6.Task2.V29.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void NumberInput(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-24-1 Донской Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int endValue = Convert.ToInt32(textBoxEndValue.Text);

                double[] ans = ds.GetMassFunction(Convert.ToInt32(textBoxStartValue.Text), Convert.ToInt32(textBoxEndValue.Text));

                for (int i = 0; i < ans.Length; i++)
                {
                    this.dataGridViewFunctionTab.Rows.Add("" + startValue, ans[i] + "");

                    this.chartResult.Series[0].Points.AddXY(startValue, ans[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.LawnGreen;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.DarkGreen;
        }
    }
}
