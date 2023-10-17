class Printing
{
    public void PrintQuestions(List<Quiz>myquiz)
     {
        Console.Clear();
        foreach (Quiz a in myquiz)
        {
            System.Console.WriteLine($"Question: {a.Thequerytext}");
            System.Console.WriteLine($"Answer: {a.GetAnswer()} ");
        }
        Console.WriteLine("Please press any key to return to the menu");
        Console.ReadKey();
    }

    static public int GetScore(List<Quiz>myquiz)
    {
        int score=0;
        foreach (Quiz a in myquiz)
        {
            score += a.Points;
        }

        return score;
    }
        
            
    

    


    
}