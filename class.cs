public class Quiz
{

    public string Thequerytext {get; set;}
    public int Points {get; set;}
    
   
    public Quiz(string thequerytext, int points)
    {
        this.Thequerytext = thequerytext;
        this.Points = points;
    }

    public virtual void CorrectAnswer()
    {
        System.Console.WriteLine(Thequerytext);
        System.Console.WriteLine("What is your answer");

    }

    public virtual string GetAnswer()
    {
        return "";
    }
    

    
}
