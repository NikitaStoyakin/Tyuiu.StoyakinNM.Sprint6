using Tyuiu.StoyakinNM.Sprint6.Task1.V28.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SNM.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SNM.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep,stopStep);
                textBoxResult_SNM.Text = "";
                textBoxResult_SNM.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_SNM.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_SNM.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1, 5:f2}    |", startStep, valueArray[i]);
                    textBoxResult_SNM.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SNM.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введенны неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1.Выполнил студент групы ПКТб 24-1 Стоякин Никита Михайлович");
        }
    }
}
