using Tyuiu.StoyakinNM.Sprint6.Task4.V7.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task4.V7
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SNM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SNM.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SNM.Text = "";

                for (int i = 0; i <= len - 1; i++)
                {

                    this.chartFunction_SNM.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SNM.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введенны неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V7.txt";
                File.WriteAllText(path, textBoxResult_SNM.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " Сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4.Выполнил студент групы ПКТб 24-1 Стоякин Никита Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_SNM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
