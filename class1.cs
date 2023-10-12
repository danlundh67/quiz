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

    

}

class ThreeChoises : Quiz
{
    public string Pick {get; set;}
    public ThreeChoises(string Pick, string thequerytext): base(thequerytext)
    {
        this.Pick = Pick;
    }

}

