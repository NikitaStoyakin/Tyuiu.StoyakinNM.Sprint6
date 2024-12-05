using Tyuiu.StoyakinNM.Sprint6.Task3.V9.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
        { -14, 25, 26, 18, 17 },
        { 28, 10, 6, -2, 4 },
        { 30, 25, -3, 11, -10 },
        { 11, 32, -5, -20, 25 },
        { 2, -18, 11, 8, -20 }
            };

            int[,] wait = new int[5, 5]
            {
        { -14, 25, 26, 18, -20 },
        { 28, 10, 6, -2, -10 },
        { 30, 25, -3, 11, 4 },
        { 11, 32, -5, -20, 17 },
        { 2, -18, 11, 8, 25 }
            };

            int[,] res = ds.Calculate(matrix);

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j], $"Mismatch at index [{i},{j}]");
                }
            }
        }
    }
}