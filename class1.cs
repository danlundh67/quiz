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
    
}

class ThreeChoises : Quiz
{
    public string Pick {get; set;}
}

