using System.Collections.Concurrent;

public class Stringanswer : Quiz
{
    public string correct {set; get;}
    public string thequerytext;

    public Stringanswer(string correct, string thequerytext) : base(thequerytext)
    {
        this.correct =correct;
    }
    
}



class NumericQuestion : Quiz
{
    
    public int number {set; get;}
    public NumericQuestion(int number, string thequerytext): base(thequerytext)
    {
        this.number = number;
    }

    static public new NumericQuestion CreateQuesttion()
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

    static public new  ThreeChoises CreateQuesttion()
    {
        Console.WriteLine("State the (numerical) question:");
        string text="[1X2] " + Console.ReadLine();
        Console.WriteLine("State the correct ansver:");
        string correct=Console.ReadLine();
        ThreeChoises st = new(correct,text);
        return st;
    }

}

public class YearQuestion : Quiz
{
    public int year {get; set;}
    public YearQuestion(int year, string thequerytext): base(thequerytext)
    {
        this.year = year;
    }

    static public new YearQuestion CreateQuesttion()
    {
        Console.WriteLine("State the (year) question:");
        string text= "[Year] " + Console.ReadLine();
        Console.WriteLine("State the correct ansver:");
        int.TryParse(Console.ReadLine(), out int  correct);
        YearQuestion st = new(correct,text);
        return st;
    }

}
class TrueOrFalseQuestion : Quiz
{
    public bool IsTrue {get; set;}
    public TrueOrFalseQuestion(bool IsTrue, string thequerytext): base(thequerytext)
    {
        this.IsTrue = IsTrue;
    }

    static public new TrueOrFalseQuestion CreateQuesttion()
    {
        Console.WriteLine("State the (True or False) question:");
        string text= "[True/False] " + Console.ReadLine();
        Console.WriteLine("State the correct ansver (true or false):");
        string tmp =  Console.ReadLine();
        bool.TryParse(tmp.ToLower(), out bool correct);
        TrueOrFalseQuestion st = new(correct,text);
        return st;
    }
}

