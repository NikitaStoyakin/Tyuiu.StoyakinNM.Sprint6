using Tyuiu.StoyakinNM.Sprint6.Task7.V5.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Никита\source\repos\Tyuiu.StoyakinNM.Sprint6\Tyuiu.StoyakinNM.Sprint6.Task7.V5\bin\Debug\InPutDataFileTask7V5.csv";

            int[,] res = ds.GetMatrix(path);

            int[,] wait =
            {
            { 15, 3, 2, 2, 2, 11, 10, 2, 2, 5 },
            { 11, 2, 2, 2, 9, 16, 2, 4, 15, 2 },
            { 2, 2, 11, 2, 2, 2, 2, 12, 2, 2 },
            { 18, 4, 2, 16, 2, 2, 2, 2, 2, 17 },
            { 2, 2, 2, 20, 12, 2, 2, 2, 18, 14 },
            { 2, 2, 2, 2, 2, 2, 2, 2, 20, 2 },
            { 2, 2, 2, 2, 2, 19, 9, 2, 2, 2 },
            { 2, 2, 2, 3, 2, 2, 2, 2, 2, 2 },
            { 2, 2, 2, 16, 2, 2, 18, 2, 5, 12 },
            { 18, 2, 2, 6, 2, 5, 2, 2, 16, 2 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}