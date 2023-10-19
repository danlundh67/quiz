using System.Text.Json;

class FileHandling
{

    public static void SaveToFile(List<Quiz> myquiz, string Filename)
    {

            StreamWriter sw = new StreamWriter(Filename);
            foreach(Quiz item in myquiz)
            {

                if(item is Stringanswer child1)
                {
                   sw.WriteLine("Stringanswer;",child1.thequerytext+";", child1.Points +";", child1.correct);
                }

            }
            sw.Close();

        string strJson = JsonSerializer.Serialize(myquiz, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(Filename, strJson);
    }

       
}