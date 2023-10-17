
public class YearQuestion : Quiz
{
    public int year {get; set;}
    public YearQuestion(int year, string thequerytext, int points): base(thequerytext, points)
    {
        this.year = year;
        
    }
    public override void CorrectAnswer()
    {
        System.Console.WriteLine(Thequerytext);
        System.Console.WriteLine("What is your answer");
        int.TryParse(Console.ReadLine(),out int answer);
        if (answer == year)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
            Points = 0;
        }
        
    }

}
class TrueOrFalseQuestion : Quiz
{
    public bool IsTrue {get; set;}
    public TrueOrFalseQuestion(bool IsTrue, string thequerytext, int points): base(thequerytext, points)
    {
        this.IsTrue = IsTrue;
    }
public override void CorrectAnswer()
    {
        System.Console.WriteLine(Thequerytext);
        System.Console.WriteLine("What is your answer (true/false)");
        string boolAnswer = "" + Console.ReadLine();
        if (bool.TryParse(boolAnswer, out bool answer))
        {    
            if (answer == IsTrue)
            {
                Console.WriteLine("Correct answer");
            }
            else
            {
                Console.WriteLine("Incorrect answer");
                Points = 0;
            }
        }else
        {
            System.Console.WriteLine("Invalid answer. Please enter 'true' or 'false'.");
            Points = 0;
        }
        
    }
}
public class MultipleChoises : Quiz
{
    List<string> Choices = new List<string>();
    public string Correctchoice;

    public MultipleChoises (string thequerytext, int points, List<string> choices) : base(thequerytext, points)
    {
        this.Choices = choices;
    }
    public void SetCorrectChoice(string choice)
    {
        Correctchoice = choice;
        
    }
    public override void CorrectAnswer()
    {
        System.Console.WriteLine(Thequerytext);
        System.Console.WriteLine("What is your answer. There can only be one right answer!");
        string answer = "" + Console.ReadLine();
        if (Choices.Contains(answer))
        {
            if (answer == Correctchoice)
            {
                Console.WriteLine("Correct answer");
            }
            else
            {
                Console.WriteLine("Incorrect answer");
                Points = 0;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose one of the available options.");
            Points = 0;
        }
        
    }

}

