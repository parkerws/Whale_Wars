using System;
using System.Collections.Generic;
using System.Linq;
using WhaleWars;
using System.Threading;

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
        public static void PlayerDied(Whale Player, Enemies target)
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
            Console.WriteLine($"     ,;::::::;     ;'         / OOOOOOO          {Player.Name} Has been slain by {target.Name}");
            Console.WriteLine("    ;:::::::::`. ,,,;.        /  / DOOOOOO             Would you like to [E]xit or start [O]ver?");
            Console.WriteLine("  .';:::::::::::::::::;,     /  /     DOOOO");   
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
            string input = Input().ToLower();

               if(input == "o") { Console.Clear(); Program.Main();}
               if (input == "e") { Environment.Exit(0);}
            if (input != "e" || input != "o") { PlayerDied(Player, target); } 
            
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
            
        }
        public static List<Weapon> WhaleShop(Whale Player, List<Weapon> inventory, List<Item> items)
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
            
            int j = 1;
            foreach (Item it in items)
            {
                
                if (j == 1) { Console.WriteLine($"Item {j})  {it.Name} Cost {it.cost}"); }
                if (j == 2) { Console.WriteLine($"Item {j})  {it.Name} Cost {it.cost}"); }
                if (j == 3) { Console.WriteLine($"Item {j})  {it.Name} Cost {it.cost}"); }
                if (j == 4) { Console.WriteLine($"Item {j})  {it.Name} Cost {it.cost}"); }
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

        public static List<Item> ItemListGenerator()
        {
            List<Item> itemStore = new List<Item>();
            itemStore.Add(Item.ItemGen("health"));
            itemStore.Add(Item.ItemGen("health"));
            itemStore.Add(Item.ItemGen("armor"));
            itemStore.Add(Item.ItemGen("magic"));
            return itemStore;
        }

        public static void Shop1(Whale Player)
        {
            Console.Clear();
            HUD(Player);

           List<Item> Items = ItemListGenerator();
           List<Weapon> Weaps = ShopListGenerator(Player);
           
            Goose1();
            Thread.Sleep(2500);

            Console.Clear();
            HUD(Player);

            Goose2();

            int i = 1;
            foreach (Weapon W in Weaps)
            {
                
                if (i == 1) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 5 Doubloons   "); }
                if (i == 2) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 1 Doubloons   "); }
                if (i == 3) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloons   "); }
                if (i == 4) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 3 Doubloons   "); }
                i++;
            };

            int j = 5;
            foreach (Item it in Items)
            {

                if (j == 5) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloons"); }
                if (j == 6) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloons"); }
                if (j == 7) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloons"); }
                if (j == 8) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloons"); }
                j++;
            };
            Fork fork = new Fork();
            Console.WriteLine($"Item 9)  fork Cost 32 Doubloon");

            Console.WriteLine("[E] to [E]xit, [S] to [S]ell");

            string input = Input().ToLower();
            switch (input)
            {
                case "1": { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 5;  Console.Clear(); return ; }
                case "2": { Whale.UpgradeWeapon(Player, Weaps.ElementAt(1)); Player.Wallet -= 4;  Console.Clear(); return ; }
                case "3": { Whale.UpgradeWeapon(Player, Weaps.ElementAt(2)); Player.Wallet -= 4;  Console.Clear(); return ; }
                case "4": { Whale.UpgradeWeapon(Player, Weaps.ElementAt(3)); Player.Wallet -= 3;  Console.Clear(); return ; }
                case "5": { Player.inventory.Add(Items[0]); Player.Wallet -= Items[0].cost; return; }
                case "6": { Player.inventory.Add(Items[1]); Player.Wallet -= Items[1].cost; return; }
                case "7": { Player.inventory.Add(Items[2]); Player.Wallet -= Items[2].cost; return; }
                case "8": { Player.inventory.Add(Items[3]); Player.Wallet -= Items[3].cost; return; }
                case "9": { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 32;  Console.Clear(); return; }
                case "s": { Sell(Player); Shop1(Player); return; }
                default: return ;
            }
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
            Console.ForegroundColor = ConsoleColor.Green;
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
                case "s": { ConsoleInterface.WhaleShop(Player, ConsoleInterface.ShopListGenerator(Player), ConsoleInterface.ItemListGenerator()); return; }
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

            //Console.WriteLine(Player.GetInventory());

            foreach (var item in Player.EquipedWeapon)
            {
                Console.WriteLine($"Equiped Weapon :: {item.Name} :: {item.Damage}");
            }
            foreach (var item in Player.EquipedArmor)
            {
                Console.WriteLine($"Equiped Armor  :: {item.Name} :: {item.defense}");
            }

            foreach (var item in Player.inventory)
            {
                Console.WriteLine($"Item :: {item.Name}");
            }

            Console.WriteLine("\nPress [ENTER] to return to the ship");
            Input();
            Console.Clear();
            Ship(Player);
        }
        public static void Sell(Whale Player)
        {
            Console.Clear();
            HUD(Player);

            Console.WriteLine("Select an Item to sell.");

            int i = 1;
            foreach (var item in Player.inventory)
            {
                Console.WriteLine($"{i}) {item.Name} :: Sells for {item.cost} Doubloons");
                i++;
            }

            string input = Input().ToLower();
            switch (input)
            {
                case "1": { Player.Wallet += Player.inventory[0].cost; Player.inventory.Remove(Player.inventory[0]); return; }
                case "2": { Player.Wallet += Player.inventory[1].cost; Player.inventory.Remove(Player.inventory[1]); return; }
                case "3": { Player.Wallet += Player.inventory[2].cost; Player.inventory.Remove(Player.inventory[2]); return; }
                case "4": { Player.Wallet += Player.inventory[3].cost; Player.inventory.Remove(Player.inventory[3]); return; }
                case "5": { Player.Wallet += Player.inventory[4].cost; Player.inventory.Remove(Player.inventory[4]); return; }
                case "6": { Player.Wallet += Player.inventory[5].cost; Player.inventory.Remove(Player.inventory[5]); return; }

                default: return;
            }
        }

        public static void Goose1()
        {
            Console.Clear();
            Console.WriteLine("                                   ___");
            Console.WriteLine("                              ,-''   `.");
            Console.WriteLine("                             ,'  _   e )`-._");
            Console.WriteLine("                            /  ,' `-._<.===-'");
            Console.WriteLine("                           /  /");
            Console.WriteLine("                          /  ;");
            Console.WriteLine("              _.--.__    /   ;");
            Console.WriteLine(" (`._    _.-''       ;--'    |");
            Console.WriteLine(" <_  `-''                     \"");
            Console.WriteLine("  <`-                          :");
            Console.WriteLine("   (__   <__.                  ;");
            Console.WriteLine("     `-.   '-.__.      _.'    /");
            Console.WriteLine("        \'      `-.__,-'    _,'");
            Console.WriteLine("         `._    ,    /__,-'");
            Console.WriteLine("            ''._\'__,'< <____");
            Console.WriteLine("                 | |  `----.`.");
            Console.WriteLine("                 | |        \' `.");
            Console.WriteLine("                 ; |___      \'-``");
            Console.WriteLine("                 \'   --<");
            Console.WriteLine("                  `.`.<");
            Console.WriteLine("                    `-'");
            Console.WriteLine("Well Hello, Stranger.");
            Console.WriteLine("I'm Bobo the whale, i know what your thinking...");
            Console.WriteLine("How could i be a whale, well ill tell you a secret");
            Console.WriteLine("Im Dolf-lundfins first and only child, lucky for you i have some pretty nice wears.");
        }
        public static void Goose2()
        {
            Console.WriteLine("                                    _");
            Console.WriteLine("                                ,-'' ''.");
            Console.WriteLine("                              ,'  ____  `.");
            Console.WriteLine("                            ,'  ,'    `.  `._");
            Console.WriteLine("   (`.         _..--.._   ,'  ,'        \'   \"");
            Console.WriteLine("  (`-.\'   .-''        '''   /          (  d _b");
            Console.WriteLine(" (`._  `-'' ,._             (            `-(   \"");
            Console.WriteLine(" <_  `     (  <`<            \'             `-._\"");
            Console.WriteLine("  <`-       (__< <           :");
            Console.WriteLine("   (__        (_<_<          ;");
            Console.WriteLine("  ----`--------------------------------------------------------");
            Console.WriteLine("SO! What you buying?");
        }

    }
}