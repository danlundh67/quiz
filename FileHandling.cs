using System.Text.Json;
using System.IO;

class FileHandling
{

    public static void SaveToFile(List<Quiz> myquiz, string Filename)
    {

            StreamWriter sw = new StreamWriter(Filename);
            foreach(Quiz item in myquiz)
            {

                if(item is Stringanswer child1)
                {
                   sw.WriteLine($"Stringanswer;{child1.Thequerytext};{child1.Points};{child1.correct}");
                }
                else if (item is NumericQuestion child2)
                {
                     sw.WriteLine($"NumericQuestion;{child2.Thequerytext};{child2.Points};{child2.number}");
                }
                else if (item is ThreeChoises child3)
                {
                     sw.WriteLine($"ThreeChoises;{child3.Thequerytext};{child3.Points};{child3.Pick}");
                }
                else if (item is YearQuestion child4)
                {
                     sw.WriteLine($"YearQuestion;{child4.Thequerytext};{child4.Points};{child4.year}");
                     
                }
                else if (item is TrueOrFalseQuestion child5)
                {
                     sw.WriteLine($"TrueOrFalseQuestion;{child5.Thequerytext};{child5.Points};{child5.IsTrue}");
                }
                else if (item is MultipleChoises child6)
                {
                     sw.WriteLine($"MultipleChoises;{child6.Thequerytext};{child6.Points};{child6.Correctchoice}");
                }

            }
            sw.Close();
            

        
    }

       
}