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
    

    public void DoSomething(string correct)
    {
        Console.WriteLine(Thequerytext);
        string answer = "" +Console.ReadLine();
        if (answer == correct)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
            System.Console.WriteLine("----------------");
        }
    }
    
    public void DoSomething(bool correct)
    {
         Console.WriteLine(Thequerytext);
        string answer = "" +Console.ReadLine();
        bool.TryParse(answer.ToLower(), out bool result);

        if (result == correct)
        {
            Console.WriteLine("Correct answer");
            System.Console.WriteLine("----------------");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
            System.Console.WriteLine("----------------");
        }
    }
}
