using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DonskoiIA.Sprint6.Task6.V16.Lib;

namespace Tyuiu.DonskoiIA.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string path;
        private void buttonFileLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(path);
            groupBoxIn.Text = "Ввод " + openFileDialogTask.FileName;
            
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();

                textBoxOut.Text = ds.CollectTextFromFile(path);
            }
            catch
            {
                MessageBox.Show("Не найден файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
