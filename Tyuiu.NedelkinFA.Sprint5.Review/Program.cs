using Tyuiu.NedelkinFA.Sprint5.Review.Lib;

DataService ds = new DataService();
string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V1.txt");
string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");

Console.WriteLine("file tut: " + path);
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine("resultat: " + pathSaveFile);
Console.ReadKey();
