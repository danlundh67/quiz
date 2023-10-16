namespace quizzen
{


    

    class Program
    {

        static public List<Quiz> myquiz = new List<Quiz>();
        static public void queryfill()
        {   bool flag = true;
            while (flag)
            {
                System.Console.WriteLine("--------------------------------");
                System.Console.WriteLine("| [1] Add year question        |");
                System.Console.WriteLine("| [2] Ta bort en artikel       |");
                System.Console.WriteLine("| [3] quit                     |");
                System.Console.WriteLine("--------------------------------");
                System.Console.Write("Val: ");
                int menu = int.Parse("" + Console.ReadLine());

                switch (menu)
                {
                    case 1:
                       System.Console.WriteLine("State the year question!");
                       string yeartext = "" + Console.ReadLine();
                       System.Console.WriteLine("What is the correct asnwer?");
                       int.TryParse(Console.ReadLine(),out int years);
                       System.Console.WriteLine("How many points is the question worth?");
                       int.TryParse(Console.ReadLine(),out int points);
                       YearQuestion yearQuestion = new YearQuestion(years, yeartext, points); 
                       myquiz.Add(yearQuestion);
                       System.Console.WriteLine("Year question added!");

                       break;
                    case 2:
                      
                        break;
                    case 3:
                        flag = false;
                        break;
                    case 4:
                       
                        break;
                    case 5:
                        
                    
                    default:
                        break;
                }
            // välja frågetyp
                // läs in frågetext 
                // läs in poängen
                // läs in rätt svar
                // skapa objekt av frågetypen 

            
            }
            


        }



        static void Main(string[] args)
        {
            

            queryfill();

           
               
           foreach(Quiz item in myquiz)
            {
                
                if(item is Stringanswer child1)
                {
                    child1.DoSomething(child1.correct);
                }
                else if(item is NumericQuestion child2)
                {
                    //child2.DoSomething(child2.number);
                }
                else if (item is ThreeChoises child3)
                {
                    child3.DoSomething(child3.Pick);
                }
                else if (item is TrueOrFalseQuestion child4)
                {
                    child4.DoSomething(child4.IsTrue);
                }
                else if (item is YearQuestion child5)
                {
                    System.Console.WriteLine(child5.Thequerytext);
                    //child5.DoSomething(child5.year);
                    child5.CorrectAnswer();
                }
                

            }

            

            
        }
    }
}
