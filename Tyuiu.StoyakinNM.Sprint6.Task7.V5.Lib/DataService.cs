using System.Data.Common;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoyakinNM.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            string[] file = File.ReadAllLines(path);

            int columns = file[0].Split(";").Length;
            int rows = file.Length;

            int[,] matrix = new int[rows, columns];

            int xCol = 9;

            for(int i = 0; i < rows; i++)
            {
                string[] digits = file[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    int digit = Convert.ToInt32(digits[j]);
                    if (j == xCol && digit < 2 )
                    {
                        matrix[i, j] = 2;
                    }
                    else
                    {
                        matrix[i, j] = digit;
                    }
                }
            }
            return matrix;
        }
    }
}
