using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine("       ,:::::'  .  . ;           OOO\"");
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
        public static void WinArt(Enemies target)
        {
            Console.Clear();
            Console.WriteLine("__________________________________________________________________________________________________________________");
            Console.WriteLine("                  _|\'");
            Console.WriteLine("                 `._.\'_");
            Console.WriteLine("                     | `.");
            Console.WriteLine("         __   ||      `._\'_ ,'\",'|                __");
            Console.WriteLine("     ,._/|||,.||________,_._ _,_'_____________,-;|||\'_________");
            Console.WriteLine("     '.----; /||------------.-.-\"------------/ '.---,---------'");
            Console.WriteLine("        \'__,' ||     / (_)|`-'-__;           `.___/");
            Console.WriteLine("        / :|  ''      |    |,-.\'|             |::.\"                        CONGRADULATIONS ");
            Console.WriteLine($"       /___|         | .: ||_,  |   __...     |____\"          you have defeated {target.Name}");
            Console.WriteLine("        | |  _..._    |.:  `.__, | ,'   .:|     | |");
            Console.WriteLine("        | | `-. .:''._|___:_....'-'-. .:' /     | |");
            Console.WriteLine("        ;-:---'`.:' _\'`._           /`.-./--.__;-:");
            Console.WriteLine("       /_,'------\','     `--...__,-'   \'---.../_`_\"");
            Console.WriteLine("                 ' `.:       .          |");
            Console.WriteLine("                     \'       ::    |   :|");
            Console.WriteLine("                     |      .:     ;  .:;");
            Console.WriteLine("                     |    .::     /  ::/");
            Console.WriteLine("            ,-.     / __...----.._ .::/  ,-.");
            Console.WriteLine("           <'-'>   /-'.::::' `::::`-./  <'-'>");
            Console.WriteLine("   ,     ,'`,' \'  ,'_.::.-----....__:| _,' :`.");
            Console.WriteLine(" /'|\'   /  ; \' \'/                 _,-' _,'\'  \'       .");
            Console.WriteLine(" |':\\  ; ,'   \' \'_...---'''''---,' _,-'    `. \'     /|\'");
            Console.WriteLine("  \':\'`-'/     .\' \'               ,'/         `.\'   //.|");
            Console.WriteLine("   \':\' /      `.`._          _,-','            \'`-'/:/");
            Console.WriteLine("    `-'=*       `-.`''----'''_,-'               \' /:/");
            Console.WriteLine("                   `'''---'''                  *=`-'");
            Console.WriteLine();
            Console.WriteLine("__________________________________________________________________________________________________________________");
        }
        public static List<Weapon> WhaleShop(Whale user, List<Weapon> inventory)
        {
            Console.Clear();
            Console.WriteLine("___________________________________________________________________________________________");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("            .-------------'```'----....,,__                        _,");
            Console.WriteLine("            |                               `'`'`'`'-.,.__        .'(");
            Console.WriteLine("            |                                             `'--._.'   )");
            Console.WriteLine("            |                                                   `'-.<");
            Console.WriteLine("            \';              .-'`'-.                            -.    `\'");
            Console.WriteLine("             \'               -.o_.     _                     _,-'`\'   |");
            Console.WriteLine("              ``````''--.._.-=-._    .'  \'           _,,--'`      `-._(");
            Console.WriteLine("                (^^^^^^^^`___    '-. |    \' __,,..--'                 `");
            Console.WriteLine("                 `````````   `'--..___\'   |`");
            Console.WriteLine("                                       `-.,'");
            Console.WriteLine("Please enter the number of the item you would like to buy or enter Exit to leave the shop");
            Console.WriteLine("___________________________________________________________________________________________");

            Console.WriteLine();
            int i = 1;
            foreach (Weapon item in inventory)
            {
                string[] type = { "Fire", "Lightning", "Ice", "Rusty", "Broken" };
                Random r = new Random();
                int nt = r.Next(type.Length);
                string st = type[nt];
                if (i == 1) { Console.WriteLine($"Item {i}) {st} {item.Name}, {item.Damage} damage, Cost 5 Doubloon   "); }
                if (i == 2) { Console.WriteLine($"Item {i}) {st} {item.Name}, {item.Damage} damage, Cost 1 Doubloon   "); }
                if (i == 3) { Console.WriteLine($"Item {i}) {st} {item.Name}, {item.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 4) { Console.WriteLine($"Item {i}) {st} {item.Name}, {item.Damage} damage, Cost 3 Doubloon   "); }
                i++;
            };
            Console.WriteLine();

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": { user.Armory.Add(inventory.ElementAt(0)); user.Wallet -= 5; return user.Armory; }
                case "2": { user.Armory.Add(inventory.ElementAt(1)); user.Wallet -= 1; return user.Armory; }
                case "3": { user.Armory.Add(inventory.ElementAt(2)); user.Wallet -= 4; return user.Armory; }
                case "4": { user.Armory.Add(inventory.ElementAt(3)); user.Wallet -= 3; return user.Armory; }
                default: break;
            }

            return user.Armory;

        }
        public static List<Weapon> ShopListGenerator()
        {
            List<Weapon> sp = new List<Weapon>();
            sp.Add(Weapon.CreateWeapon(WeaponList.Knife));
            sp.Add(Weapon.CreateWeapon(WeaponList.Bow));
            sp.Add(Weapon.CreateWeapon(WeaponList.Sword));
            sp.Add(Weapon.CreateWeapon(WeaponList.Wand));
            return sp;
        }

        public static void HUD(Whale player)
        {
            
            string location = player.currentPlanet.ToString();
            string playerName = player.Name;
            int Health = player.Health;
            int turn = 1;
            int Attack = player.Offense;
            int Defence = player.Defense;
          
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
            Console.Write("    " + playerName);
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
            Console.Write(Defence + " Defence \n");  // this would be so much easier if Guse could spell.....
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