using System;

namespace WhaleWars
{
    public static class ConsoleInterface
    {

        public static string Input()
        {
            string name = null;
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    name += key.KeyChar;
                    Console.Write($"{key.KeyChar}");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && name.Length > 0)
                    {
                        name = name.Substring(0, (name.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }

            } while (true);
            return name;
        }
        public static void PlayerDied(Whale user, Enemies target)
        {
            Console.Clear();
            Console.WriteLine("__________________________________________________________________________________________________________________");
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("               ...");
            Console.WriteLine("             ;::::;");
            Console.WriteLine("           ;::::; :;");
            Console.WriteLine("         ;:::::'   :;");
            Console.WriteLine("        ;:::::;     ;.");
            Console.WriteLine("       ,:::::'       ;           OOO\"");
            Console.WriteLine("       ::::::;       ;          OOOOO\"");
            Console.WriteLine("       ;:::::;       ;         OOOOOOOO");
            Console.WriteLine($"     ,;::::::;     ;'         / OOOOOOO          {user.Name} Has been slain by {target.Name}");
            Console.WriteLine("    ;:::::::::`. ,,,;.        /  / DOOOOOO             Would you like to [E]xit or start [O]ver?");
            Console.WriteLine("  .';:::::::::::::::::;,     /  /     DOOOO");   // yes or no what?? hella ambiguous
            Console.WriteLine(" ,::::::;::::::;;;;::::;,   /  /        DOOO");
            Console.WriteLine(";`::::::`'::::::;;;::::: ,#/  /          DOOO");
            Console.WriteLine(":`:::::::`;::::::;;::: ;::#  /            DOOO");
            Console.WriteLine("::`:::::::`;:::::::: ;::::# /              DOO");
            Console.WriteLine("`:`:::::::`;:::::: ;::::::#/               DOO");
            Console.WriteLine(" :::`:::::::`;; ;:::::::::##                OO");
            Console.WriteLine(" ::::`:::::::`;::::::::;:::#                OO");
            Console.WriteLine(" `:::::`::::::::::::;'`:;::#                O");
            Console.WriteLine("  `:::::`::::::::;' /  / `:#");
            Console.WriteLine("   ::::::`:::::;'  /  /   `#");
            Console.WriteLine("_________________________________________________________________________________________________________________");
            string input = Convert.ToString(Input().ToLower());
            
            switch(input.ToLower())
            {
                case "o": { Console.Clear(); Program.Main();  break; }
                case "e":  { Environment.Exit(0); break; }
            }           
        }

        public static void HUD(string player = "", string location= "", int turn = 0, int Health = 0, int Attack = 0, int Defence = 0)
        {
          
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Whale-Wars");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    " + player);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(location);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("turn " + turn + " /20");
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Health + " Health ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Attack + " Attack ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Defence + " Defence \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================\n\n\n\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" The Combat and Story Text will Apear hear! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" When you take Damage it will apear in RED! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" When you Attack it will apear in YELLOW! ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" When you Heal it will apear in GREEN!\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================");

        }
    }
}