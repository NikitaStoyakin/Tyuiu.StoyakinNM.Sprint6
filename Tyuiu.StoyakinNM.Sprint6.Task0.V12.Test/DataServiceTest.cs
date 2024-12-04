using Tyuiu.StoyakinNM.Sprint6.Task0.V12.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}