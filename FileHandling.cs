using System.Text.Json;

class FileHandling
{

    public static void SaveToFile(List<Quiz> myquiz, string Filename)
    {
            foreach(Quiz item in myquiz)
            {

                if(item is Stringanswer child1)
                {
                   Console.WriteLine("Stringanswer",child1.thequerytext, child1.Points, child1.correct);
                }

            }

        string strJson = JsonSerializer.Serialize(myquiz, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(Filename, strJson);
    }

    public static List<Quiz> ReadFromFile(string Filename)
    {
        string strJson = File.ReadAllText(Filename);
        return JsonSerializer.Deserialize<List<Quiz>>(strJson); 
    }
    
}