public class Quiz
{

    public string Thequerytext {get; set;}

    // points egenskap (även i underklass)
   
    public Quiz(string thequerytext)
    {
        this.Thequerytext = thequerytext;
    }

    static public Quiz CreateQuestion() // i underklasser
    {
        Console.WriteLine("State the (string) question:");
        string text=Console.ReadLine();
        Console.WriteLine("State the correct ansver:");
        string correct = Console.ReadLine();
        Stringanswer st = new(correct,text);
        return st;
    }

    public void DoSomething(string correct)
    {
        Console.WriteLine(Thequerytext);
        string answer=Console.ReadLine();
        if (answer == correct)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
        }
    }
    public void DoSomething(int correct)
    {
         Console.WriteLine(Thequerytext);
        string answer=Console.ReadLine();
        int.TryParse(answer,out int result);

        if (result == correct)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
        }
    }
    public void DoSomething(bool correct)
    {
         Console.WriteLine(Thequerytext);
        string answer=Console.ReadLine();
        bool.TryParse(answer.ToLower(), out bool result);

        if (result == correct)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
        }
    }
}
