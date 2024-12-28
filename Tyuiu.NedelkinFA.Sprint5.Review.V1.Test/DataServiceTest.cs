using Tyuiu.NedelkinFA.Sprint5.Review.V1.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Review.V1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RemoveDigitsFromFileContent()
        {
            string inputPath = Path.Combine(Path.GetTempPath(), "InPutFileTask7V1.txt");
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

            File.WriteAllText(inputPath, "123 Привет, это тестовая строка 456.");

            DataService ds = new DataService();
            ds.LoadDataAndSave(inputPath);

            string result = File.ReadAllText(outputPath).Trim();
            Assert.AreEqual("Привет, это тестовая строка .", result);
        }
    }
}