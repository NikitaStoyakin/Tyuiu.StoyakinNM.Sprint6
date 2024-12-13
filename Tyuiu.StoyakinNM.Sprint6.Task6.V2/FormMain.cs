using Tyuiu.StoyakinNM.Sprint6.Task6.V2.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog_SNM.ShowDialog();
            openFilePath = openFileDialog_SNM.FileName;
            textBoxInput_SNM.Text = File.ReadAllText(openFilePath);
            groupBoxTwo_SNM.Text = groupBoxTwo_SNM.Text + " " + openFileDialog_SNM.FileName;
            buttonDone_SNM.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxResult_SNM.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_Click (object sender, EventArgs e)
        {
            FormAbout_SNM formAbout = new FormAbout_SNM();
            formAbout.ShowDialog();
        }
    }
}
