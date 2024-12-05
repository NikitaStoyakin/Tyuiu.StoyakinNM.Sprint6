using Tyuiu.StoyakinNM.Sprint6.Task2.V10.Lib;
namespace Tyuiu.StoyakinNM.Sprint6.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -24.04;
            valueWaitArray[1] = -20.32;
            valueWaitArray[2] = -7.91;
            valueWaitArray[3] = -9.9;
            valueWaitArray[4] = -5.81;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = -0.19;
            valueWaitArray[7] = 3.9;
            valueWaitArray[8] = 1.91;
            valueWaitArray[9] = 14.32;
            valueWaitArray[10] = 18.04;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}