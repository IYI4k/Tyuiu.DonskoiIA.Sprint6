using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DonskoiIA.Sprint6.Task4.V15.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        double[] ans;
        bool Is_ans_Empty = true;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V15.txt" });

                if (Is_ans_Empty)
                {
                    DialogResult dialogResultEmpty = MessageBox.Show("Ответ пуст. Вы хотите обнулить данные в файле?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResultEmpty == DialogResult.Yes)
                    {
                        FileInfo fEmpty = new FileInfo(path);
                        if (fEmpty.Exists)
                        {
                            File.Delete(path);
                        }
                    }
                    goto SAVEEXIT;
                }
                int ansLengthMinus = ans.Length - 1;

                FileInfo f = new FileInfo(path);
                if (f.Exists)
                {
                    File.Delete(path);
                }

                for (int i = 0; i < ansLengthMinus; i++)
                {
                    File.AppendAllText(path, ans[i] + Environment.NewLine);
                }
                File.AppendAllText(path, ans[ansLengthMinus] + "");

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            SAVEEXIT:
                {
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NumberInput(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int StartValue = Convert.ToInt32(textBoxStartValue.Text);
                int EndValue = Convert.ToInt32(textBoxEndValue.Text);

                if (EndValue < StartValue)
                {
                    goto DATAINPUTERROR;
                }

                ans = ds.GetMassFunction(StartValue, EndValue);
                int ansLengthMinus = ans.Length - 1;
                Is_ans_Empty = false;

                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult.Series[0].Points.Clear();

                textBoxTable.Text = "";

                for (int i = 0; i < ansLengthMinus; i++)
                {
                    textBoxTable.AppendText(ans[i] + Environment.NewLine);
                    this.chartResult.Series[0].Points.AddXY(StartValue++, ans[i]);
                }
                this.chartResult.Series[0].Points.AddXY(StartValue++, ans[ansLengthMinus]);
                textBoxTable.AppendText(ans[ansLengthMinus] + "");

                goto DATAINPUTOK;

            DATAINPUTERROR:
                {
                    MessageBox.Show("Введённый конец шага меньше начала шага", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            DATAINPUTOK:
                {
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-24-1 Донской Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
