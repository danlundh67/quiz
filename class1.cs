using System.Collections.Concurrent;

public class Stringanswer : Quiz
{
    public string correct {set; get;}
    public string thequerytext;

    public Stringanswer(string correct, string thequerytext) : base(thequerytext) //add points
    {
        this.correct =correct;
    }

    // rätta frågan (jfr progam.cs DoSomething), sätta points
    
}



class NumericQuestion : Quiz
{
    
    public int number {set; get;}
    public NumericQuestion(int number, string thequerytext): base(thequerytext)
    {
        this.number = number;
    }

    static public new NumericQuestion CreateQuestion()
    {
        Console.WriteLine("State the (numerical) question:");
        string text= "[Number] " + Console.ReadLine();
        Console.WriteLine("State the correct ansver:");
        int.TryParse(Console.ReadLine(), out int  correct);
        NumericQuestion st = new(correct,text);
        return st;
    }
    

}

class ThreeChoises : Quiz
{
    public string Pick {get; set;}
    public ThreeChoises(string Pick, string thequerytext): base(thequerytext)
    {
        this.Pick = Pick;
    }

    static public new  ThreeChoises CreateQuestion()
    {
        Console.WriteLine("State the (numerical) question:");
        string text="[1X2] " + Console.ReadLine();
        Console.WriteLine("State the correct ansver:");
        string correct=Console.ReadLine();
        ThreeChoises st = new(correct,text);
        return st;
    }

}
