using System;
using System.Collections.Generic;
using System.Linq;

namespace WhaleWars
{
    public static class ConsoleInterface
    {
        public static string Input()
        {
            string name = "";
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

            switch (input.ToLower())
            {
                case "o": { Console.Clear(); Program.Main(); break; }
                case "e": { Environment.Exit(0); break; }
            }
        }
        public static void WinArt(Whale Player, Enemies target)
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
            Console.WriteLine("Press [ENTER] to continue");
            Input();
            ConsoleInterface.Ship(Player);
        }
        public static List<Weapon> WhaleShop(Whale Player, List<Weapon> inventory)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

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
            Console.WriteLine("[E]xit");
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": { Whale.UpgradeWeapon(Player, inventory.ElementAt(0)); Player.Wallet -= 5; Ship( Player); Console.Clear(); return null; }
                case "2": { Whale.UpgradeWeapon(Player, inventory.ElementAt(1)); Player.Wallet -= 1; Ship( Player); Console.Clear(); return null; }
                case "3": { Whale.UpgradeWeapon(Player, inventory.ElementAt(2)); Player.Wallet -= 4; Ship(Player); Console.Clear(); return null; }
                case "4": { Whale.UpgradeWeapon(Player, inventory.ElementAt(3)); Player.Wallet -= 3; Ship( Player); Console.Clear(); return null; }
                default:  Ship(Player); return null;
            }

        }
        public static List<Weapon> ShopListGenerator(Whale Player)
        {
            List<Weapon> sp = new List<Weapon>();
            sp.Add(Weapon.WeaponGen(Player));
            sp.Add(Weapon.WeaponGen(Player));
            sp.Add(Weapon.WeaponGen(Player));
            sp.Add(Weapon.WeaponGen(Player));
            return sp;
        }
        public static void HUD(Whale player)
        {
            Whale.ArmoryDefense(player); //used to update the hud defense
            Whale.ArmoryOffense(player); //used to update the hud offense

            string location = player.currentPlanet.ToString();
            string playerName = player.Name;
            int Health = player.Health;
            int Gold = player.Wallet;
            int Attack = player.Offense;
            int Defence = player.Defense;
            int MagicPoints = player.MagicPoints;

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
            Console.Write("Doubloons " + Gold);
            Console.ResetColor();
            Console.Write(" :: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Health + " HP ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(MagicPoints + " MP ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Attack + " ATK ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Defence + " DEF \n");  // this would be so much easier if Guse could spell.....
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================================================================\n\n\n\n");
            Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine(" The Combat and Story Text will Apear hear! ");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(" When you take Damage it will apear in RED! ");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(" When you Attack it will apear in YELLOW! ");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(" When you Heal it will apear in GREEN!\n");
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("====================================================================================");

        }

        public static void Ship(Whale Player)
        {
           Console.Clear();

            ConsoleInterface.HUD(Player);

            Console.WriteLine("Ship HUB" +
               "\nEnter I for [I]nventory\n" +
               "Enter C for [C]ombat\n" +
               "Enter S for [S]hop\n" +
               "Enter e for [E]quip different weapon\n");
            string input = Input();
            switch (input.ToLower())
            {
                case "i": {PlayerInventory(Player); return; }
                case "c": { Combat.Battle(Player, Enemies.EnemyGenerator()); return; }
                case "s": { ConsoleInterface.WhaleShop(Player, ConsoleInterface.ShopListGenerator(Player)); return; }
                case "e": { Whale.changeWeapon(Player); Ship(Player); return ;  }

                        default:
                    break;
            }
            
        }

        public static void PlayerInventory(Whale Player)
        {
            Console.Clear();

            HUD(Player);
            Console.WriteLine($"{Player.Name}'s Inventory\n");

            Console.WriteLine(Player.GetInventory());

            foreach (var item in Player.EquipedWeapon)
            {
                Console.WriteLine($"Equiped Weapon :: {item.Name} :: {item.Damage}");
            }
            foreach (var item in Player.EquipedArmor)
            {
                Console.WriteLine($"Equiped Armor  :: {item.Name} :: {item.defense}");
            }

            Console.WriteLine("\nPress [ENTER] to return to the ship");
            Input();
            Console.Clear();
            Ship(Player);
        }

    }
}