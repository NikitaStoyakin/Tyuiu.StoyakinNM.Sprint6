using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoyakinNM.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            // Извлекаем пятый столбец
            int[] fifthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fifthColumn[i] = matrix[i, 4];
            }

            // Сортируем пятый столбец по возрастанию
            Array.Sort(fifthColumn);

            // Заменяем значения в пятом столбце отсортированными значениями
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = fifthColumn[i];
            }

            return matrix;
        }
    }
}
