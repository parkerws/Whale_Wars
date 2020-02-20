using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Game
    {
        
        //Character name
        static string characterName = "";
        //Print out game title and setup

        public static void startGame()
        {
            //Fastwrite("Whale Wars!", "blue\n");
          //  Console.WriteLine("\nPress Space to continue...");
            Console.ReadKey();
            Console.Clear();
            Typewrite("\nWelcome to the console based adventure game!", "dialog\n\n");
            Fastwrite("\nYou wake up floating through space...", "dialog\n\n");
            Console.WriteLine("\nPress space to continue...");
            Console.ReadKey();
           // nameCharacter();

        }

        public static string PlayerName()
        {
            Console.Clear();
            Typewrite("\nWhat is thy name?", "self");
            Fastwrite("\nType in your name: ", "dialog\n");
            string name = ConsoleInterface.Input();
            return name;
        }

        //ask plaer for a name and save it
        public static Whale nameCharacter(string name)
        {
            Console.Clear();            
            
            Whale Player = new Whale(name, CharClass.fighter, 1, 1, 1, 1);
            Player = Whale.WhaleSelect(Player, name);

            Whale.StartItems(Player);

            ConsoleInterface.HUD(Player);

            Typewrite($"\n{Player.Name}", "yellow");
            Typewrite("...ya, It's all coming back to me now", "self");
            Typewrite("\n... What happened?", "self");
            Typewrite("\n... Where am I?", "self");
            Console.WriteLine("\nPress Space to continue...");
            Console.ReadKey();
            Console.Clear();

            ConsoleInterface.HUD(Player);

            Fastwrite("\nYou look around... You see thousands of stars...", "dialog");
            Typewrite("\n...I must have blacked out...", "self");
            Typewrite("\n...I don't remember anything.", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();

            ConsoleInterface.HUD(Player);

            Fastwrite("\nYou see a small planet off in the distance...", "dialog");
            Typewrite("\nThat looks like Blowholia Prime... wait...", "self");
            Typewrite("\nBlowholia... I think I was there... something bad happened...", "self");
            Typewrite("\nI can't remember... maybe there are some answers there", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            return Player;
        }
        public static void Choice(Whale Player)
        {
            ConsoleInterface.HUD(Player);

            string input = "";
            Typewrite($"\n{Player.Name}", "yellow");
            Fastwrite(", Do you want to go too Blowholia Prime?", "dialog");
            Console.WriteLine("\nA) Yes" +
                "\nB) No");
            input = input.ToUpper();
            input = Console.ReadLine();
            if (input == "A")
            {
                Fastwrite("\n You point your ship towards Blowholia Prime", "dialog");
            }
            else
            {
                Typewrite("\n I need to find out what happened to me", "self");
            }

        }
        public static void preBlowholiaDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            Typewrite("\nMeanwhie on blowholia...", "dialog\n");
            Fastwrite("\nThe sounds of exploading space cannons tear through the thin Blowholia morning air","red");
            Typewrite("\nBrave Bloholian solders are trudging through the mud of the battle field","dialog");
            Typewrite("\n\"Is the day lost sir?\"", "friend");
            Typewrite("one Blowholian sergeant says to", "dialog");
            Typewrite(" Captain Whalord-Hookfin", "friend");
            Typewrite("\nCpt.Hookfin: \"For today.. But hope is not\"", "friend");
            Typewrite("\nHe say's with a grin, as he watches your ship enter the atmosphere", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadLine();
            Console.Clear();

        }

        static void Typewrite(string message, string color)
        {
            if (color == "enemy")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "friend")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == "self")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (color == "dialog")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(45);

            }
            Console.ResetColor();

        }
        static void Fastwrite(string message, string color)
        {
            if (color == "enemy")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "friend")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == "self")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (color == "dialog")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (color == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(25);

            }
            Console.ResetColor();

        }
    }

}
