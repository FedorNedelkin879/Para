using Tyuiu.NedelkinFA.Sprint5.Review.V1.Lib;

DataService ds = new DataService();
string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V1.txt");
string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V1.txt");
Console.WriteLine("file tut: " + path);
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine("resultat: " + pathSaveFile);
Console.ReadKey();