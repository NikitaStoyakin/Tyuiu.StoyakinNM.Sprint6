using Tyuiu.StoyakinNM.Sprint6.Task7.V5.Lib;
using System.IO;
using System.Windows.Forms;
namespace Tyuiu.StoyakinNM.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_SNM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SNM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for(int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for(int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOut_SNM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_SNM.Enabled = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SNM.ShowDialog();
            openFilePath = openFileDialogTask_SNM.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_SNM.ColumnCount = colums;
            dataGridViewIn_SNM.RowCount = rows;
            dataGridViewOut_SNM.ColumnCount = colums;
            dataGridViewOut_SNM.RowCount = rows;

            for(int i = 0; i < colums; i++)
            {
                dataGridViewIn_SNM.Columns[i].Width = 25;
                dataGridViewOut_SNM.Columns[i].Width = 25;
            }

            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < colums; c++)
                {
                    dataGridViewIn_SNM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SNM.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SNM.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SNM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SNM.ShowDialog();

            string path = saveFileDialogMatrix_SNM.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_SNM.RowCount;
            int columns = dataGridViewOut_SNM.ColumnCount;

            string str = "";

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_SNM.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_SNM.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_SNM.ColumnCount = 50;
            dataGridViewOut_SNM.ColumnCount = 50;

            dataGridViewOut_SNM.RowCount = 50;
            dataGridViewIn_SNM.RowCount = 50;

            panelTwo_SNM.Width = this.Width / 2;

            for(int i = 0; i < 50; i++)
            {
                dataGridViewIn_SNM.Columns[i].Width = 25;
                dataGridViewOut_SNM.Columns[i].Width = 25;
            }
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SNM.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SNM.ToolTipTitle = "Выполнить";
        }
        private void buttonSaveFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SNM.ToolTipTitle = "Сохранить файл";
        }
        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SNM.ToolTipTitle = "Справка";
        }
    }
}
