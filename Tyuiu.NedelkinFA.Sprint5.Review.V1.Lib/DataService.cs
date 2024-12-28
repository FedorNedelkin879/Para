using System.Text.RegularExpressions;

namespace Tyuiu.NedelkinFA.Sprint5.Review.V1.Lib
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            using (StreamWriter writer = new StreamWriter(pathSaveFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string resultLine = Regex.Replace(line, "\\d", "");
                    writer.WriteLine(resultLine);
                }
            }

            return pathSaveFile;
        }
    }
}
