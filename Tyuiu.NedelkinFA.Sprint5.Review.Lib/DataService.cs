using System.IO;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace Tyuiu.NedelkinFA.Sprint5.Review.Lib;

public class DataService 
{
    public string LoadDataAndSave(string path)
    {
        string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");
        path = "C:\\Users\\Федя\\AppData\\Local\\Temp\\InPutDataFileTask7V1.txt";
        if (File.Exists(pathSaveFile))
        {
            File.Delete(pathSaveFile);
        }
        string aa = "";
        using (var fs = new FileStream(pathSaveFile, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fs))
            {
                aa = reader.ReadToEnd();
            }
        }

        aa.Replace("\\d", "");

        using (var fs = new FileStream(pathSaveFile, FileMode.Create, FileAccess.Write))
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(aa);
            }
        }

        return pathSaveFile;
    }
}
