using Tyuiu.StoyakinNM.Sprint6.Task5.V29.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\Никита\source\repos\Tyuiu.StoyakinNM.Sprint6\Tyuiu.StoyakinNM.Sprint6.Task5.V29\bin\Debug\InPutDataFileTask5V29.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SNM.ColumnCount = 2;
            dataGridViewResult_SNM.Columns[0].Width = 20;
            dataGridViewResult_SNM.Columns[1].Width = 50;

            this.chartFunction_SNM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_SNM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_SNM.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_SNM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_SNM.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5.Выполнил студент групы ПКТб 24-1 Стоякин Никита Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
