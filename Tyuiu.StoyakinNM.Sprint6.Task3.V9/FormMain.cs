using Tyuiu.StoyakinNM.Sprint6.Task3.V9.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-14, 25, 26, 18, 17, },
                                          {28, 10, 6, -2, 4, },
                                          {30, 25, -3, 11, -10, },
                                          {11, 32, -5, -20, 25, },
                                          {2, -18, 11, 8, -20, } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            dataGridViewOne_SNM.ColumnCount = colums;
            dataGridViewOne_SNM.RowCount = colums;

            for(int i = 0; i < colums; i++)
            {
                dataGridViewOne_SNM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    dataGridViewOne_SNM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxResult_SNM.Text = Convert.ToString(ds.Calculate(mtrx));
        }
        private void buttonReference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3.Выполнил студент групы ПКТб 24-1 Стоякин Никита Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
