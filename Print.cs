class Printing
{
    public void PrintQuestions(List<Quiz>myquiz)
     {
        Console.Clear();
        foreach (Quiz a in myquiz)
        {
            System.Console.WriteLine($"Question: {a.Thequerytext}");
            System.Console.WriteLine($"Answer: ");
        }
        Console.WriteLine("Please press any key to return to the menu");
        Console.ReadKey();
    }
        
            
    

    


    
}