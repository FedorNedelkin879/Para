using Tyuiu.NedelkinFA.Sprint5.Review.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Review.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void RemoveDigitsFromFileContent()
        {
            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V1.txt");
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

            File.WriteAllText(inputPath, "123 Привет, это тестовая строка 456.");

            DataService ds = new DataService();
            ds.LoadDataAndSave(inputPath);

            string result = File.ReadAllText(outputPath).Trim();
            Assert.AreEqual("Привет, это тестовая строка .", result);
        }
    }
}