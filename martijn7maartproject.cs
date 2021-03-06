using System;

namespace rolldice
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
            #########  SOFTWAREDEVELOPER 2020/2021 ##############
            #####################################################
            #####################################################
            #####################################################
            #####################################################
            #####################################################
            #####################################################
            #####################################################
            */

            // =========================================================================
            // =========================================================================
            // =========================================================================
            // DECLARATIES VAN BENODIGDE VARIABELEN + INIT
            // dobelsteen randomization
            Random rnd = new Random();
            /* MAX toegestane spelers*/
            int maxpl = 4;
            /*declareer variabele voor  het aantal vereiste spelers aan */
            int[] player = new int[maxpl];
            
            /* choice menu variables */
            bool cont = true;
            /* PLAY GAME VAR */
            // bijhouden van aantal rondes + intialze to zero at start of game
            int round_num = 0;
            bool play_game = false;

            /* init number of players*/
            int plnum = 0;

            // END DECLARATIES VAN BENODIGDE VARIABELEN + INIT
            // =========================================================================
            // =========================================================================
            // =========================================================================
            // =========================================================================
            /* DISPLAY START OPTIONS */
            StartMenu();

            /* make sure correct number of player is given */
            SetPlayerNumber(); // if plauing sets play_game to TRUE

            /* START ACTUAL GAME */
            InitPlayers();
            do
            {
                RollDice();
 
            }
            while (play_game);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
           
            //start menu tell user to use numbers to activate switch menu to read rules, proceed, and exit the game
            void StartMenu()
            {
                while (cont)
                {
                    Console.WriteLine("\n\n==================================================================");
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("to read the rules press (1)");
                    Console.WriteLine("to start the game up press (2)");
                    Console.WriteLine("to close the game (3)");
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("==================================================================");
                    Console.WriteLine("==================================================================\n\n");


                    string menu = Console.ReadLine();

                    //declare what happens in what case like switch menu to read rules, proceed, and exit the game
                    switch (menu)
                    {
                        case "1":
                            //statement 
                            GameRules(); ;
                            break;
                        case "2":
                        default:
                            Console.WriteLine("oke lets start!");
                            play_game = true;
                            cont = false;
                            break;

                        case "3":
                            //statement 
                            ExitGame();
                            cont = false;
                            break;
                    }
                }
            }
            
            
            
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            void GameRules()
            {
                /* explains game rules to player as string
                 and divines maxplayers as string*/
                int[] player = new int[maxpl];
                Console.WriteLine("#1 max players = 4 more will return you to the menu");
                Console.WriteLine("#2 each player is handed 2 dicecubes");
                Console.WriteLine("#3 the dicecubes have 6 sides each one having a number higher than the ohter");
                Console.WriteLine("#4 the player with the highest points in a round wins the round 1/5 total rounds");
                Console.WriteLine("#5 the player who wins most rounds wins the game goodluck!");
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            void InitPlayers()
            {
                /* maak het aantal vereiste spelers aan */
                player = new int[plnum];
                String pl = Convert.ToString(plnum);
                
                /*if "string": + int == pl == string and int as writeline: is concarenation of strings*/
                Console.WriteLine("Number of players is: " + pl);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            void RollDice()
            { /* start counting rounds give db1/db2 an preset int declare int ranked   */

                round_num++;
                Console.WriteLine("\n\n  round: " + round_num);
                int db1 = 0, db2 = 0;

                int[] ranked= new int[4];
                


                for (int i = 0; i <= plnum - 1; i++)
                { // rnd.Next(1, 7); // creates a number between 1 and 6
                    // gooi the dobbelsteen
                    // player array onthoud som van de twee gegooide dobbelstenen
                    db1 = rnd.Next(1, 7);
                    db2 = rnd.Next(1, 7);
                    player[i] = player[i] + db1 + db2;
                    //Array.Sort(player); SORTING
                    Console.WriteLine("\n\n player: " + (i + 1) + " dobbel1: " + db1 + " dobbel2: " + db2 + " outcome:   " + player[i] + "\n\n");


                }

                tryAgain();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* DETERMINE how many players */

            void SetPlayerNumber()
            {
                /*ask players int of players between int1 and int4 if int is false repeat question till int == correct int if int correct proceed game*/
                do
                {
                    Console.WriteLine("How many players? (MIN ONE)(MAX FOUR)");
                    plnum = Convert.ToInt32(Console.ReadLine());
                }
                while (plnum <= 0 || plnum >= 5);

                /*lets players know they gave correct int and can continue with their game*/
                Console.WriteLine("oke u enterd the correct number!");
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*exitgame == shut aplication off*/
            void ExitGame()
            {
                play_game = false;
                Console.WriteLine("oke goodbye!");
                System.Environment.Exit(-1);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            void tryAgain()
            {
                Console.WriteLine("play again yes or no as [y/n] : ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "y")
                {
                    play_game = true;
                    Console.WriteLine("oke anohter round it is");
                }
                else if (userInput == "n")
                {


                    Console.WriteLine("oke that was the game see you next time?");
                    cont = true;
                    
                    /* clear gaming vars */
                    round_num = 0;
                    Array.Clear(player, 0, player.Length);

                    /* DISPLAY START OPTIONS */
                    StartMenu();

                    /* make sure correct number of player is given */
                    SetPlayerNumber(); // if plauing sets play_game to TRUE

                    /* START ACTUAL GAME */
                    InitPlayers();
                }
                
            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        }
    }
}
