
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

    
}
public class MultipleChoises : Quiz
{
    List<MultipleChoises> Choices = new List<MultipleChoises>();
    public string choice;

    public MultipleChoises (string choice, string thequerytext, int points) : base(thequerytext, points)
    {
        this.choice = choice;
    }
}

