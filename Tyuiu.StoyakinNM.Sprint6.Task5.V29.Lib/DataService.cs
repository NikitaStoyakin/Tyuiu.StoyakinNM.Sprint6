using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoyakinNM.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V29.txt");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(x => x >= 10).ToArray();

            return numsArray;
        }
    }
}
