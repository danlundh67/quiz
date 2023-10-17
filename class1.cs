using System.Collections.Concurrent;
using System.Formats.Asn1;

public class Stringanswer : Quiz
{
    public string correct {set; get;}
    public string thequerytext;

    public Stringanswer(string correct, string thequerytext, int points) : base(thequerytext, points) 
    {
        this.correct =correct;
    }


    public override void CorrectAnswer()
    {
        
        base.CorrectAnswer();
        string answer = "" + Console.ReadLine();
        if (answer == correct)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
            Points = 0;
        }
        
    }

    public override string GetAnswer()
    {
        return correct;
    }
    
}



class NumericQuestion : Quiz
{
    
    public int number {set; get;}
    public NumericQuestion(int number, string thequerytext, int points): base(thequerytext, points)
    {
        this.number = number;
    }

    public override void CorrectAnswer()
    {
        
        base.CorrectAnswer();
        int.TryParse(Console.ReadLine(),out int answer);
        if (answer == number)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
            Points = 0;
        }
        
    }

    public override string GetAnswer()
    {
        string b = "" + number;
        return b;
    }
    

}

class ThreeChoises : Quiz
{
    public string Pick {get; set;}
    public ThreeChoises(string Pick, string thequerytext, int points): base(thequerytext , points)
    {
        this.Pick = Pick;
    }

    public override void CorrectAnswer()
    {
        System.Console.WriteLine(Thequerytext);
        System.Console.WriteLine("What is your answer [1X2]:?");
        string answer=Console.ReadLine() + "";
        if (answer == Pick)
        {
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Incorrect answer");
            Points = 0;
        }
        
    }

    public override string GetAnswer()
    {
        string b = "" + Pick;
        return b;
    }

}
