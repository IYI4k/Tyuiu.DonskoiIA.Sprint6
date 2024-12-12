using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DonskoiIA.Sprint6.Task7.V18.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int[,] matrix;
        string path;

        int RowsCount = 0;
        int ColumnsCount = 0;

        private int[,] LoadFromFileData(string path)
        {
            RowsCount = 0;
            ColumnsCount = 0;

            string Text = File.ReadAllText(path).Replace('\n', '\r');
            string[] TextSplitedByN = Text.Split('\r').Except(new string[] { "" }).ToArray();
            RowsCount = TextSplitedByN.Length;
            ColumnsCount = TextSplitedByN[0].Split(";").Length;

            int[,] ans = new int[RowsCount, ColumnsCount];

            int pos = 0;

            foreach (string line in TextSplitedByN)
            {
                string[] Splitedline = line.Split(";");
                for (int i = 0; i < ColumnsCount; i++)
                {
                    ans[pos, i] = Convert.ToInt32(Splitedline[i]);
                }
                pos++;

            }

            return ans;
        }
        private void buttonFileLoad_Click(object sender, EventArgs e)
        {
            openFileDialogLoadFile.ShowDialog();
            path = openFileDialogLoadFile.FileName;

            matrix = LoadFromFileData(path);

            dataGridViewIn.ColumnCount = ColumnsCount;
            dataGridViewIn.RowCount = RowsCount + 1;
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToResizeColumns = false;

            for (int i = 0; i < ColumnsCount; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
            }

            for (int i = 0; i < RowsCount; i++)
            {
                dataGridViewIn.Rows[i].Height = 25;
            }

            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    dataGridViewIn.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            matrix = ds.GetMatrix(path);

            dataGridViewOut.ColumnCount = ColumnsCount;
            dataGridViewOut.RowCount = RowsCount + 1;
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToResizeColumns = false;

            for (int i = 0; i < ColumnsCount; i++)
            {
                dataGridViewOut.Columns[i].Width = 25;
            }

            for (int i = 0; i < RowsCount; i++)
            {
                dataGridViewOut.Rows[i].Height = 25;
            }

            for (int i = 0; i < RowsCount; i++)
            {
                for (int j = 0; j < ColumnsCount; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = "OutPutFileTask7.csv";
                saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog.ShowDialog();

                string path = saveFileDialog.FileName;

                FileInfo f = new FileInfo(path);
                if (f.Exists)
                {
                    File.Delete(path);
                }

                string s = "";

                for (int i = 0; i < RowsCount; i++)
                {
                    for (int j = 0; j < ColumnsCount - 1; j++)
                    {
                        s += matrix[i, j] + ";";
                    }
                    s += matrix[i, ColumnsCount - 1] + Environment.NewLine;
                }

                File.AppendAllText(path, s.TrimEnd());
            }
            catch
            {
                MessageBox.Show("—бой при сохранении файла", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
