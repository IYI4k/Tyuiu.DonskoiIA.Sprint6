using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint6.Task1.V2.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-24-1 Донской Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NumberInput(object sender, KeyPressEventArgs e)
        {
            //if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == 8))
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue.Text);
                int endValue = Convert.ToInt32(textBoxEndValue.Text);
                
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                double[] ans = ds.GetMassFunction(startValue, endValue++);
                int pos = 0;

                string line = "";

                while (startValue < endValue)
                {
                    string String_startValue = startValue + "";
                    int dlina = (10 - String_startValue.Length) / 2;
                    line = "|" + new String(' ', dlina) + String_startValue + new String(' ', 10 - dlina - String_startValue.Length) + "|";

                    string String_Value = ans[pos] + "";
                    dlina = (10 - String_Value.Length) / 2;
                    line += new String(' ', dlina) + ans[pos++] + new String(' ', 10 - dlina - String_Value.Length) + "|" + Environment.NewLine;

                    textBoxResult.AppendText(line);
                    textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
