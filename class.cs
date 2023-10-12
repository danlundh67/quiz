public class Quiz
{

    public string Thequerytext {get; set;}
    public Quiz(string thequerytext)
    {
        this.Thequerytext = thequerytext;
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
}
