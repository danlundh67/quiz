using System.Text.Json;

class FileHandling
{

    public static void SaveToFile(List<Quiz> myquiz, string Filename)
    {
        string strJson = JsonSerializer.Serialize(myquiz, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(Filename, strJson);
    }

    public static List<Quiz> ReadFromFile(string Filename)
    {
        string strJson = File.ReadAllText(Filename);
        return JsonSerializer.Deserialize<List<Quiz>>(strJson); 
    }
    
}