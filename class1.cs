using System.Collections.Concurrent;

public class Stringanswer : Quiz
{
    public string correct {set; get;}
    public string thequerytext;

    public Stringanswer(string correct, string thequerytext, int points) : base(thequerytext, points) //add points
    {
        this.correct =correct;
    }

    // rätta frågan (jfr progam.cs DoSomething), sätta points
    
}



class NumericQuestion : Quiz
{
    
    public int number {set; get;}
    public NumericQuestion(int number, string thequerytext, int points): base(thequerytext, points)
    {
        this.number = number;
    }

    
    

}

class ThreeChoises : Quiz
{
    public string Pick {get; set;}
    public ThreeChoises(string Pick, string thequerytext, int points): base(thequerytext , points)
    {
        this.Pick = Pick;
    }

    

}
