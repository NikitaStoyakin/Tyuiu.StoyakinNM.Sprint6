using Tyuiu.StoyakinNM.Sprint6.Task5.V29.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V29.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}