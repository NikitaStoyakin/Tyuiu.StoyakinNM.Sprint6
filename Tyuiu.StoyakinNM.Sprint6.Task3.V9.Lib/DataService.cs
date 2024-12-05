using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoyakinNM.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            var rowsList = new List<int[]>();

            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }
                rowsList.Add(row);
            }

            rowsList.Sort((row1, row2) => row1[4].CompareTo(row2[4]));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowsList[i][j];
                }
            }

            return matrix;
        }
    }
}
