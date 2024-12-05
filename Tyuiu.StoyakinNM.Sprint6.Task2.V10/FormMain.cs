using Tyuiu.StoyakinNM.Sprint6.Task2.V10.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task2.V10
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

                this.chartFunction_SNM.Titles.Add("График функции");

                this.chartFunction_SNM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SNM.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOne_SNM.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_SNM.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введенны неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2.Выполнил студент групы ПКТб 24-1 Стоякин Никита Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SNM.BackColor = Color.Red;
        }

        private void buttonDone_MouseLEave(object sender, EventArgs e)
        {
            buttonDone_SNM.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SNM.BackColor = Color.Blue;
        }

    }
}
