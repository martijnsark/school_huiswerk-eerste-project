using System;

namespace vakantie_project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
#####################################################
#####################################################
#####################################################
#####################################################
######### this game is made by martijn ##############
#########  GAMERDEV 2020/2021         ###############
#####################################################
#####################################################
#####################################################
#####################################################
#####################################################
#####################################################
#####################################################
*/


            //giving the continue statement worth 0 instant start

            for (int i = 1; i <= 1; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

          
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------");

            //name strings and names array
            string[] names      = new string[5]; 
            string[] commment   = new string[5]; 
            string[] answer     = new string[5]; 

            names[0] = "shadowstalker";

            names[1] = "tenno";

            names[2] = "clem";

            names[3] = "vay hek";

            names[4] = "tyl regor";


            


            // print and read names and awnser array 
            // asking a yes/no string from user + ask to continue
            Console.WriteLine(names[0]);
            Console.WriteLine("1:comment edgy", names[0]);
            Console.Write("user, do you like shadowstalker yes/no?: ");
            answer[0] = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------");

            Console.WriteLine(names[1]);
            Console.WriteLine("2:comment we play as them.", names[1]);
            Console.Write("user, do you like tenno yes/no?: ");
            answer[1] = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------");

            Console.WriteLine(names[2]);
            Console.WriteLine("3:comment clem grakata.", names[2]);
            Console.Write("user, do you like clem yes/no?: ");
            answer[2] = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------");

            Console.WriteLine(names[3]);
            Console.WriteLine("3:comment ughhh vay hek.", names[3]);
            Console.Write("user, do you like vay hek yes/no?: ");
            answer[3] = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------");

            Console.WriteLine(names[4]);
            Console.WriteLine("4:comment its hammer time!.", names[4]);
            Console.Write("user, do you like tyl regor yes/no?: ");
            answer[4] = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\n\n-----------------------------------------------");


            // A array of all possible responses to player
            string[] randomawnser = {    "me too", 
                                    "of course", 
                                    "really?", 
                                    "makes sense",
                                    "idn about that", 
                                    "do you now?", "need a second opinion?", "i hate him",
                                    "i like him", "oke" };




            //for if loop repeat all statements and charachters that said yes

            Console.WriteLine("the charachters u liked");

            Console.WriteLine("\n\n-----------------------------------------------");
            
            for (int i = 0; i <= 4; i++)
            {
                if (answer[i] == "yes")
                Console.WriteLine("{0}, {1}, {2}, {3}", names[i]," answer was: ", answer[i], "\n ");
             
            }

            // Create a Random object  
            Random rand = new Random();
            
            // Generate a random indexes with arrays  
            int index = rand.Next(randomawnser.Length);
            Console.WriteLine($"my opinion on your first opinion {randomawnser[index]}");
            Console.ReadKey();
            int index1 = rand.Next(randomawnser.Length);
            Console.WriteLine($"my opinion on your second opinion {randomawnser[index1]}");
            Console.ReadKey();
            int index2 = rand.Next(randomawnser.Length);
            Console.WriteLine($"my opinion on your third opinion {randomawnser[index2]}");
            Console.ReadKey();
            int index3 = rand.Next(randomawnser.Length);
            Console.WriteLine($"my opinion on your fourth opinion {randomawnser[index3]}");
            Console.ReadKey();
            int index4 = rand.Next(randomawnser.Length);
            Console.WriteLine($"my opinion on your fiveth opinion {randomawnser[index4]}");
            Console.ReadKey();



            
            //ending program

            Console.WriteLine("\n\n-----------------------------------------------");
            Console.WriteLine("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}

