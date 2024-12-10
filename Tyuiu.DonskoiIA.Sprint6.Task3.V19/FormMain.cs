using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DonskoiIA.Sprint6.Task3.V19.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int[,] matrix = new int[5, 5];
        private void FormMain_Load(object sender, EventArgs e)
        {
            int KolvoStrok = matrix.GetUpperBound(0) + 1;
            int KolvoStolbov = matrix.Length / KolvoStrok;

            dataGridViewDataInput.RowCount = KolvoStrok + 1;
            dataGridViewDataInput.ColumnCount = KolvoStolbov;

            dataGridViewDataInput.RowHeadersVisible = false;
            dataGridViewDataInput.ColumnHeadersVisible = false;

            for (int i = 0; i < KolvoStolbov; i++)
            {
                dataGridViewDataInput.Columns[i].Width = 55;
                dataGridViewDataInput.Rows[i].Height = 55;
            }
            dataGridViewDataInput.AllowUserToAddRows = false;


            dataGridViewResult.RowCount = KolvoStrok + 1;
            dataGridViewResult.ColumnCount = KolvoStolbov;

            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.ColumnHeadersVisible = false;


            for (int i = 0; i < KolvoStolbov; i++)
            {
                dataGridViewResult.Columns[i].Width = 55;
                dataGridViewResult.Rows[i].Height = 55;
            }
            dataGridViewResult.AllowUserToAddRows = false;

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
                DataService ds = new DataService();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridViewDataInput.Rows[i].Cells[j].Value);
                    }
                }

                int[,] ans = ds.Calculate(matrix);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(ans[i, j] + " ");
                        dataGridViewResult.Rows[i].Cells[j].Value = ans[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewDataInput_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl textBoxEditingControl = e.Control as DataGridViewTextBoxEditingControl;
            if (textBoxEditingControl != null)
            {
                textBoxEditingControl.KeyPress += NumberInput;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-24-1 Донской Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
