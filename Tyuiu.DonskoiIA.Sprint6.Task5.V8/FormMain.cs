using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DonskoiIA.Sprint6.Task5.V8.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string path = Path.Combine(new string[] { Path.GetTempPath(), "Task5V8Input.txt" });
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewTable.RowHeadersVisible = false;
            dataGridViewTable.ColumnHeadersVisible = false;

            dataGridViewTable.ColumnCount = 2;
            dataGridViewTable.Columns[0].Width = 20;
            dataGridViewTable.Columns[0].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "��� X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "��� Y";

            chartDiag.Series[0].Points.Clear();

            DataService ds = new DataService();



            double[] Numbers = ds.LoadFromDataFile(path);

            for (int i = 0; i < Numbers.Length; i++)
            {
                dataGridViewTable.Rows.Add(i + "", Numbers[i]);
                chartDiag.Series[0].Points.AddXY(i, Numbers[i]);
            }
            dataGridViewTable.AllowUserToAddRows = false;
        }

        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ������ ������-24-1 ������� ���� ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
