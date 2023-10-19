class Filehandling2
{

public static List<Quiz> ReadFromFile(string Filename)
    {

         StreamReader sr = new StreamReader(Filename);
         List<Quiz> tmp =new List<Quiz>();
        //Read the first line of text
        string line = sr.ReadLine();
        //Continue to read until you reach end of file
        while (line != null)
        {
            //write the line to console window
            Console.WriteLine(line);

            // split på line (rad)
            string[] words = line.Split(';');
            // om 1:a texten är Stringanswer - skapa stringanswer objekt

            if (words[0] == "Stringanswer")
            {
                Stringanswer myst = new Stringanswer(words[3],words[1],int.Parse(words[2]));
                tmp.Add(myst);
            }
            else if (words[0] == "NumericQuestion")
            {
                NumericQuestion myst2 = new NumericQuestion(int.Parse(words[3]), words[1], int.Parse(words[2]));
                tmp.Add(myst2);
            }
            else if (words[0] == "ThreeChoises")
            {
                ThreeChoises myst3 = new ThreeChoises(words[3],words[1],int.Parse(words[2]));
                tmp.Add(myst3);
            }
            else if (words[0] == "YearQuestion")
            {
                YearQuestion myst4 = new YearQuestion(int.Parse(words[3]), words[1], int.Parse(words[2]));
                tmp.Add(myst4);
            }
            else if (words[0] == "TrueOrFalseQuestion")
            {
                TrueOrFalseQuestion myst5 = new TrueOrFalseQuestion(bool.Parse(words[3]), words[1], int.Parse(words[2]));
                tmp.Add(myst5);
            }
            else if (words[0] == "MultipleChoises")
            {
                List<string> choice = new List<string>();
                for (int i=3;i < words.Length; i++)
                {
                    choice.Add(words[i]);
                }
                    // is something wrong with Multiple Choice constructor?
                MultipleChoises myst6 = new MultipleChoises(words[1], words[3],int.Parse(words[2]), choice);
                tmp.Add(myst6);
            }


            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();

        
        return tmp; 
    }
 }