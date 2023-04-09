static public class Program
{
    private const string FilePath2 = "%AppData/lesson12Homework.txt";
    public static async Task Main(string[] args)
    {
        string information;
        StreamReader streamreader = new StreamReader(FilePath2);
        information = streamreader.ReadToEnd();
        streamreader.Close();
        try
        {

            if (String.IsNullOrEmpty(information))
            {
                throw new Exception("Информации в файле нет");
            }
            else
            {
                using (FileStream fstream = File.OpenRead(information))
                {
                
                   using var fstr = new System.IO.FileStream(information, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    DATA data = new DATA();
                    data = (DATA)new Bf.Deserialize(fstr);
                    IEnumerable<DATA> query = data.OrderBy(data => data.lastWriteTimev);
                    Console.WriteLine($"Текст из файла: {query}");
                    File.Delete(FilePath2);
                }

            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
        
    } 
}