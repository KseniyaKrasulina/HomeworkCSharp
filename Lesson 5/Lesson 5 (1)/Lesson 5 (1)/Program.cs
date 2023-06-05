using Lesson_5__1_;
using System.IO.Compression;
static public class Program 
{
    private const string DirectoryPath = "C:/Users/Kseniya/Documents/c#/Lesson 5 (1)/unzip";
    private const string FilePath = "C:/Users/Kseniya/Documents/c#/Lesson 5 (1)/data.csv";
    private const string FilePath2 = "%AppData%/Lesson12Homework.txt";
    public static void Main(string[] args)
    {
        using FileStream zipFile = File.Open("files.zip", FileMode.Open);
        {
            using (var archive = new ZipArchive(zipFile))
            {
                archive.ExtractToDirectory(DirectoryPath);
                DirectoryInfo directory = new DirectoryInfo(DirectoryPath);
                if (directory.Exists)
                {
                    using var fileStream = new FileStream(FilePath, FileMode.Create);
                    DirectoryInfo[] dirs = directory.GetDirectories();
                    foreach (DirectoryInfo dir in dirs)
                    {
                        DATA[] DATAdir = new DATA[dirs.Length];
                        for (int i = 1; i < dirs.Length; i++)
                        {
                            DATAdir[i] = new DATA ("папка", dir.Name, dir.LastWriteTime);
                            Console.WriteLine($"тип {DATAdir[i].typev} /t название {DATAdir[i].namev} /t дата изменения {DATAdir[i].lastWriteTimev} /n");
                            using var streamWriter = new StreamWriter(fileStream);
                            streamWriter.Write($"тип {DATAdir[i].typev} /t название {DATAdir[i].namev} /t дата изменения {DATAdir[i].lastWriteTimev}/n");
                            streamWriter.Close();
                        }
                    }

                    FileInfo[] files = directory.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        DATA[] DATAfile = new DATA[dirs.Length];
                        for (int j = 1; j < files.Length; j++)
                        {
                            DATAfile[j] = new DATA("файл", file.Name, file.LastWriteTime);
                            Console.WriteLine($"тип {DATAfile[j].typev}/t название {DATAfile[j].namev} /t дата изменения{DATAfile[j].lastWriteTimev} /n");
                            using var streamWriter = new StreamWriter(fileStream);
                            streamWriter.Write($"тип {DATAfile[j].typev} /t название{DATAfile[j].namev} /t дата изменения{DATAfile[j].lastWriteTimev} /n");
                            streamWriter.Close();
                        }


                    }



                }
                else
                {
                    Console.WriteLine("Такой директории не существует");
                }
            }
            Directory.Delete("files.zip");
        }
        

    }
    static void SavePath()
    {
        using var fileStream1 = new FileStream(FilePath2, FileMode.Create);
        using var streamWriter1 = new StreamWriter(fileStream1);
        streamWriter1.Write(FilePath);
        streamWriter1.Close();
    }
}
   

