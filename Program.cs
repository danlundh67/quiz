namespace quizzen
{


    

    class Program
    {
        static public Printing prints = new Printing();
        static public List<Quiz> myquiz = new List<Quiz>();
        static public void queryfill()
        {   bool flag = true;
            while (flag)
            {
                System.Console.WriteLine("********************************");
                System.Console.WriteLine("| [1] Add year question        |");
                System.Console.WriteLine("| [2] Add text questtion       |");
                System.Console.WriteLine("| [3] Add numeric question     |");
                System.Console.WriteLine("| [4] Add True/False question  |");
                System.Console.WriteLine("| [5] Add 1X2 question         |");
                System.Console.WriteLine("| [6] Add multiple choice      |");
                System.Console.WriteLine("| [7] Print out questions      |");
                System.Console.WriteLine("| [9] Quit                     |");
                System.Console.WriteLine("********************************");
                System.Console.Write("Val: ");
                int menu = int.Parse("" + Console.ReadLine());

                switch (menu)
                {
                    case 1:
                       System.Console.WriteLine("State the year question!");
                       string yeartext = "" + Console.ReadLine();
                       System.Console.WriteLine("What is the correct answer?");
                       int.TryParse(Console.ReadLine(),out int years);
                       System.Console.WriteLine("How many points is the question worth?");
                       int.TryParse(Console.ReadLine(),out int points);
                       YearQuestion yearQuestion = new YearQuestion(years, yeartext, points); 
                       myquiz.Add(yearQuestion);
                       System.Console.WriteLine("Year question added!");

                       break;
                    case 2:
                        // string Q
                        System.Console.WriteLine("State the text (string) question!");
                        string text = "" + Console.ReadLine();
                        System.Console.WriteLine("What is the correct answer?");
                        string answer = Console.ReadLine() +"";
                        System.Console.WriteLine("How many points is the question worth?");
                        int.TryParse(Console.ReadLine(), out int points2);
                        Stringanswer stringQuestion = new Stringanswer(answer, text, points2); 
                        myquiz.Add(stringQuestion);
                        System.Console.WriteLine("Text question added!");
                        break;
                    case 3:
                        // Numeric Q
                        System.Console.WriteLine("State the numerical question!");
                        text = "" + Console.ReadLine();
                        System.Console.WriteLine("What is the correct answer?");
                        int.TryParse(Console.ReadLine(),out int number);
                        System.Console.WriteLine("How many points is the question worth?");
                        int.TryParse(Console.ReadLine(),out int points3);
                        NumericQuestion numericQuestion = new NumericQuestion(number, text, points3); 
                        myquiz.Add(numericQuestion);
                        System.Console.WriteLine("Numeric question added!");
                        break;
                    case 4:
                        // Bool
                        System.Console.WriteLine("State the true or false question!");
                        string booltext = "" + Console.ReadLine();
                        System.Console.WriteLine("What is the correct answer, true or false?");
                        string boolanswer = Console.ReadLine() +"";
                        System.Console.WriteLine("How many points is the question worth?");
                        int.TryParse(Console.ReadLine(), out int points4);
                        Stringanswer boolQuestion = new Stringanswer(boolanswer, booltext, points4); 
                        myquiz.Add(boolQuestion);
                        System.Console.WriteLine("true or false question added!");
                        break;
                    case 5:
                        // 1X2 Q
                        System.Console.WriteLine("State the [1X2] question!");
                        text = "" + Console.ReadLine();
                        System.Console.WriteLine("What is the correct answer?");
                        answer = Console.ReadLine() +"";
                        System.Console.WriteLine("How many points is the question worth?");
                        int.TryParse(Console.ReadLine(), out int points5);
                        ThreeChoises threeChoise = new ThreeChoises(answer, text, points5); 
                        myquiz.Add(threeChoise);
                        System.Console.WriteLine("1X2 question added!");
                        break;
                    case 6:
                        // Multiple Q
                        System.Console.WriteLine("State the multiple-choice question!");
                        string multiChoiceText = "" + Console.ReadLine();
                        System.Console.WriteLine("How many points is the question worth?");
                        int.TryParse(Console.ReadLine(), out int points6);
                        
                        List<string> choices = new List<string>();

                        System.Console.WriteLine("Enter the choices for the question (enter 'done' when finished):");
                        string choice = "";
                        while (true)
                        {
                            choice = ""+ Console.ReadLine();
                            if (choice.ToLower() == "done")
                                break;
                            choices.Add(choice);
                        }
                        System.Console.WriteLine("Enter the correct choice:");
                        string correctChoice = ""+ Console.ReadLine();

                        MultipleChoises multiChoiceQuestion = new MultipleChoises(multiChoiceText, points6, choices);
                        multiChoiceQuestion.SetCorrectChoice(correctChoice);
                        myquiz.Add(multiChoiceQuestion);
                        System.Console.WriteLine("Multiple-choice question added!");
                        break;
                        
                    case 7:
                       prints.PrintQuestions(myquiz);
                    break;
                    case 8:
                       
                        break;
                    case 9:   
                        flag = false;
                        break;
                    
                    default:
                        break;
                }
             

            
            }
            


        }



        static void Main(string[] args)
        {
            int totalscore;

            queryfill();
            totalscore = Printing.GetScore(myquiz);

           
               
           foreach(Quiz item in myquiz)
            { 
                item.CorrectAnswer();
            }

            int obtainedscore = Printing.GetScore(myquiz);

            Console.WriteLine($"Obtained pointes {obtainedscore} out of {totalscore} points.")


            
        }
    }
}
