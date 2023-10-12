public class Quiz{

public string Thequerytext {get; set;}
public Quiz(string thequerytext)
{
    Thequerytext = thequerytext;
}



}

public class Stringanswer : Quiz
{
    public string correct {set; get;}
    public string thequerytext;

    public Stringanswer(string correct, string thequerytext) : base(thequerytext)
    {
        this.correct =correct;
    }

}
