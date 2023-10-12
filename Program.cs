namespace quizzen
{


    

    class Program
    {

        static public List<Quiz> myquiz = new List<Quiz>();
        static public void queryfill()
        {
             Stringanswer m2 = new Stringanswer("London", "State the capital of United Kingdom");
             myquiz.Add(m2);
             NumericQuestion m3 = new NumericQuestion(7, "How many stars are there in Ursus Major?");
             myquiz.Add(m3);
             ThreeChoises m4 = new ThreeChoises("2","IFK Gothenburg played against Sirius, who won? (1: IFK, X: equal, 2 Sirius)");
             myquiz.Add(m4);
        }



        static void Main(string[] args)
        {
            //Quiz m1 = new Quiz("What is the capital of United Kingdom?");

            queryfill();

           foreach(Quiz item in myquiz)
            {
                
                if(item is Stringanswer child1)
                {
                    child1.DoSomething(child1.correct);
                }
                else if(item is NumericQuestion child2)
                {
                    child2.DoSomething(child2.number);
                }
                else if (item is ThreeChoises child3)
                {
                    child3.DoSomething(child3.Pick);
                }
                else
                {
                    // handle exeption
                }

            }

            // Stringanswer m11 = new Stringanswer
        }
    }
}
