using Tyuiu.StoyakinNM.Sprint6.Task6.V2.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\������\source\repos\Tyuiu.StoyakinNM.Sprint6\Tyuiu.StoyakinNM.Sprint6.Task6.V2\bin\Debug\InPutDataFileTask6V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}