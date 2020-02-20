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
            Console.WriteLine("\nPress the Spacebar to continue...");
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
            Console.WriteLine("\nY) Yes" +
                "\nN) No");            
            input = Console.ReadLine();
            input = input.ToUpper();
            if (input == "Y")
            {
                Fastwrite("\n You point your ship towards Blowholia Prime\n", "dialog");
                Console.WriteLine("Press Space to continue.");
                Console.ReadKey();
            }
            else
            {
                ConsoleInterface.Ship(Player);
            }

        }
        public static void preBlowholiaDialog(Whale Player)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            Typewrite("\nMeanwhie on blowholia...", "dialog\n");
            Fastwrite("\nThe sounds of exploading space cannons and dolphin's laugh tear through the thin Blowholia morning air","red");
            Typewrite("\nBrave Blowholian solders are trudging through the mud of the battle field","dialog");
            Typewrite("\n\"Is the day lost sir?\"", "friend");
            Typewrite("one Blowholian sergeant says to", "dialog");
            Typewrite(" Captain Whalord-Hookfin", "friend");
            Typewrite("\nCpt.Hookfin: \"For today.. But hope is not\"", "friend");
            Typewrite("\nHe say's with a grin, as he watches your ship enter the atmosphere\n", "dialog");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();

        }
        public static void BlowholiaDialog(Whale Player)
        {
            ConsoleInterface.HUD(Player);
            Enemies enemy = Enemies.EnemyGenerator();
 
            Fastwrite("\nYour ship comes to a holt on the outskirts of Blowholia's capital city: Pier-182", "dialog");
            Typewrite("\nTime to get some answers.", "self");
            Fastwrite("\n\"Arrived: Blowholia Prime\"", "friend");
            Typewrite(" the ships AI says over the inter inter-com.", "dialog");
            Fastwrite("\n\"Population: 5\"", "friend");
            Typewrite("\n 5!? How can that be?", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Fastwrite("\nYou quickly exit your ship and gaze upon the ruins of Pier-182", "dialog");
            Typewrite("\nWhat happened here?", "self");
            Fastwrite("\nAll of a sudden, you hear the cackle of a dolphin!", "dialog");
            Typewrite("\nOut of the fog steps the notorious", "dialog");
            Fastwrite(" Dolph Lundphin", "enemy");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nLundphin! ", "enemy");
             Fastwrite("I should've known this was your doing!", "self");
            Fastwrite("\nYou've made a big mistake comming back here, ","enemy");
            Fastwrite($"{Player.Name}!", "self");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Typewrite("\nNow you're going to die by the hand of my minion, ","enemy");
            Fastwrite($"{enemy.Name}"!, "yellow");
            Console.WriteLine("\nPress Space to continue.");
            Console.ReadKey();
            Console.Clear();
            ConsoleInterface.HUD(Player);
            Combat.Battle(Player, enemy);

        }

        private static void Typewrite(string message, string color)
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
        private static void Fastwrite(string message, string color)
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
                System.Threading.Thread.Sleep(15);

            }
            Console.ResetColor();

        }
    }

}
