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

            //Read the next line
            line = sr.ReadLine();
        }
        //close the file
        sr.Close();

        
        return tmp; 
    }
 }