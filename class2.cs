
public class YearQuestion : Quiz
{
    public int year {get; set;}
    public YearQuestion(int year, string thequerytext): base(thequerytext)
    {
        this.year = year;
    }

    static public new YearQuestion CreateQuestion()
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

    static public new TrueOrFalseQuestion CreateQuestion()
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

