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

        public static void EndGameWin()
        {
            string asciiText = @"
        _________________________________________________________________________________________________
        

                                                      *
                                                      *
                                             *        *         *
                                              *  _____*_______ *
                                                /             \
                                                |             |
                                         *****  |             | *****
&&&&&&&&&&^^^^^&&&&&&&^^^^^^^^^^^^&&&&&&&&&&&&&&&&&^^^^^^^^^^&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
&&&&&&&&&&&^^^&&&&&&&&&^^^^^^^^^^&&&&&&&&&&&&&&&&&&&^^^^^^^^&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
&&&&&&&&&&&&^&&&&&&&&&&&^^^^^^^^&&&&&&&&&&&&&&&&&&&&&^^^^^^&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
&&&&&&&&&&&&&&&&&&&&&&&&&^^^^^^&&&&&&&&&&&&&&&&&&&&&&&^^^^&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
==============================================================================================================
                                Victory! It tastes like 9-minute miles!!!

";
            Console.Write(asciiText);
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("[Y]es or [N]o.");
            string getResponse = Console.ReadLine();
            if (getResponse.ToLower() == "yes" || getResponse.ToLower() == "y")
            {
                Program.Main();
            }
            else
            {
                Console.WriteLine("Thanks for stopping by. Thanks for all the fish.");
                Environment.Exit(0);
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


        //All shops have been created, most the shops revolve around Bobo the whale (goose). feel like its a good place to add a laugh
        public static void Shop1(Whale Player)
        {
            Goose2(Player);

            List<Item> Items = ItemListGenerator();
            List<Weapon> Weaps = ShopListGenerator(Player);

            int i = 1;
            foreach (Weapon W in Weaps)
            {

                if (i == 1) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 5 Doubloon   "); }
                if (i == 2) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 1 Doubloon   "); }
                if (i == 3) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 4) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 3 Doubloon   "); }
                i++;
            };

            int j = 5;
            foreach (Item it in Items)
            {

                if (j == 5) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 6) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 7) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 8) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                j++;
            };
            Fork fork = new Fork();
            if (Player.Name == "Chaze" || Player.Name == "Nate" || Player.Name == "Diego" || Player.Name == "Will" || Player.Name == "Harley")
            { Console.WriteLine($"Item 9)  Fork Cost 1 Doubloon"); }

            Console.WriteLine("[E] to [E]xit, [S] to [S]ell");

            string input = Input().ToLower();
            switch (input)
            {
                case "1":
                    if (Player.Wallet >= 5) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 5; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "2":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(1)); Player.Wallet -= 4; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "3":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(2)); Player.Wallet -= 4; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "4":
                    if (Player.Wallet >= 3) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(3)); Player.Wallet -= 3; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "5":
                    if (Player.Wallet >= Items[0].cost) { Player.inventory.Add(Items[0]); Player.Wallet -= Items[0].cost; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "6":
                    if (Player.Wallet >= Items[1].cost) { Player.inventory.Add(Items[1]); Player.Wallet -= Items[1].cost; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "7":
                    if (Player.Wallet >= Items[2].cost) { Player.inventory.Add(Items[2]); Player.Wallet -= Items[2].cost; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "8":
                    if (Player.Wallet >= Items[3].cost) { Player.inventory.Add(Items[3]); Player.Wallet -= Items[3].cost; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "9":
                    if (Player.Wallet >= 1) { Whale.UpgradeWeapon(Player, fork); Player.Wallet -= 1; Shop1(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop1(Player); return; }
                case "s": { Sell(Player); Shop1(Player); return; }
                default: Console.WriteLine("You leave Bobo's stand and head back to the ship"); return;
            }
        } // when using this shop make sure you put the Goose1 method before it.
        public static void Shop2(Whale Player)
        {
            Goose3(Player);

            List<Item> Items = ItemListGenerator();
            List<Weapon> Weaps = ShopListGenerator(Player);

            int i = 1;
            foreach (Weapon W in Weaps)
            {

                if (i == 1) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 5 Doubloon   "); }
                if (i == 2) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 1 Doubloon   "); }
                if (i == 3) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 4) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 3 Doubloon   "); }
                i++;
            };

            int j = 5;
            foreach (Item it in Items)
            {

                if (j == 5) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 6) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 7) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 8) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                j++;
            };
            Blowhole Blowhole = new Blowhole();
            Console.WriteLine($"Item 9)  BlowHole Cost 7 Doubloon");

            Console.WriteLine("[E] to [E]xit, [S] to [S]ell");

            string input = Input().ToLower();
            switch (input)
            {
                case "1":
                    if (Player.Wallet >= 5) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 5; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "2":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(1)); Player.Wallet -= 4; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "3":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(2)); Player.Wallet -= 4; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "4":
                    if (Player.Wallet >= 3) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(3)); Player.Wallet -= 3; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "5":
                    if (Player.Wallet >= Items[0].cost) { Player.inventory.Add(Items[0]); Player.Wallet -= Items[0].cost; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "6":
                    if (Player.Wallet >= Items[1].cost) { Player.inventory.Add(Items[1]); Player.Wallet -= Items[1].cost; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "7":
                    if (Player.Wallet >= Items[2].cost) { Player.inventory.Add(Items[2]); Player.Wallet -= Items[2].cost; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "8":
                    if (Player.Wallet >= Items[3].cost) { Player.inventory.Add(Items[3]); Player.Wallet -= Items[3].cost; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "9":
                    if (Player.Wallet >= 7) { Whale.UpgradeWeapon(Player, Blowhole); Player.Wallet -= 7; Shop2(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop2(Player); return; }
                case "s": { Sell(Player); Shop2(Player); return; }
                default: return;
            }
        }// all shops are controlled by Bobo. this is a way to show that.
        public static void Shop3(Whale Player)
        {
            Goose3(Player);

            List<Item> Items = ItemListGenerator();
            List<Weapon> Weaps = ShopListGenerator(Player);

            int i = 1;
            foreach (Weapon W in Weaps)
            {

                if (i == 1) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 5 Doubloon   "); }
                if (i == 2) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 3) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 4) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 3 Doubloon   "); }
                i++;
            };

            int j = 5;
            foreach (Item it in Items)
            {

                if (j == 5) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 6) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 7) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 8) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                j++;
            };
            Blowhole Blowhole = new Blowhole();
            Console.WriteLine($"Item 9)  BlowHole Cost 6 Doubloon");

            Console.WriteLine("[E] to [E]xit, [S] to [S]ell");

            string input = Input().ToLower();
            switch (input)
            {
                case "1":
                    if (Player.Wallet >= 5) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 5; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "2":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(1)); Player.Wallet -= 4; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "3":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(2)); Player.Wallet -= 4; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "4":
                    if (Player.Wallet >= 3) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(3)); Player.Wallet -= 3; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "5":
                    if (Player.Wallet >= Items[0].cost) { Player.inventory.Add(Items[0]); Player.Wallet -= Items[0].cost; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "6":
                    if (Player.Wallet >= Items[1].cost) { Player.inventory.Add(Items[1]); Player.Wallet -= Items[1].cost; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "7":
                    if (Player.Wallet >= Items[2].cost) { Player.inventory.Add(Items[2]); Player.Wallet -= Items[2].cost; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "8":
                    if (Player.Wallet >= Items[3].cost) { Player.inventory.Add(Items[3]); Player.Wallet -= Items[3].cost; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "9":
                    if (Player.Wallet >= 6) { Whale.UpgradeWeapon(Player, Blowhole); Player.Wallet -= 6; Shop3(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop3(Player); return; }
                case "s": { Sell(Player); Shop3(Player); return; }
                default: return;
            }
        }// all shops are controlled by Bobo. this is a way to show that.
        public static void Shop4(Whale Player)
        {
            Cousin2(Player);

            List<Item> Items = ItemListGenerator();
            List<Weapon> Weaps = ShopListGenerator(Player);

            int i = 1;
            foreach (Weapon W in Weaps)
            {

                if (i == 1) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 5 Doubloon   "); }
                if (i == 2) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 3) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 4) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 3 Doubloon   "); }
                i++;
            };

            int j = 5;
            foreach (Item it in Items)
            {

                if (j == 5) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 6) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 7) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 8) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                j++;
            };
            UltraBoof Blowhole = new UltraBoof();
            Console.WriteLine($"Item 9)  UltraBoof Cost 5 Doubloon");

            Console.WriteLine("[E] to [E]xit, [S] to [S]ell");

            string input = Input().ToLower();
            switch (input)
            {
                case "1":
                    if (Player.Wallet >= 5) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 5; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "2":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(1)); Player.Wallet -= 4; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "3":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(2)); Player.Wallet -= 4; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "4":
                    if (Player.Wallet >= 3) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(3)); Player.Wallet -= 3; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "5":
                    if (Player.Wallet >= Items[0].cost) { Player.inventory.Add(Items[0]); Player.Wallet -= Items[0].cost; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "6":
                    if (Player.Wallet >= Items[1].cost) { Player.inventory.Add(Items[1]); Player.Wallet -= Items[1].cost; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "7":
                    if (Player.Wallet >= Items[2].cost) { Player.inventory.Add(Items[2]); Player.Wallet -= Items[2].cost; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "8":
                    if (Player.Wallet >= Items[3].cost) { Player.inventory.Add(Items[3]); Player.Wallet -= Items[3].cost; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "9":
                    if (Player.Wallet >= 5) { Whale.UpgradeWeapon(Player, Blowhole); Player.Wallet -= 5; Shop4(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop4(Player); return; }
                case "s": { Sell(Player); Shop4(Player); return; }
                default: return;

            }
        }//Bobo's cousin Lenard steps in for him when he is out. make sure to place Cousin 1 before this shop
        public static void Shop5(Whale Player)
        {
            BigWhale(Player);

            List<Item> Items = ItemListGenerator();
            List<Weapon> Weaps = ShopListGenerator(Player);

            int i = 1;
            foreach (Weapon W in Weaps)
            {

                if (i == 1) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 5 Doubloon   "); }
                if (i == 2) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 3) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 4 Doubloon   "); }
                if (i == 4) { Console.WriteLine($"Item {i})  {W.Name}, {W.Damage} damage, Cost 3 Doubloon   "); }
                i++;
            };

            int j = 5;
            foreach (Item it in Items)
            {

                if (j == 5) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 6) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 7) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                if (j == 8) { Console.WriteLine($"Item {j})  {it.Name}  Cost {it.cost} Doubloon"); }
                j++;
            };
            Chimichanga chim = new Chimichanga();
            Console.WriteLine($"Item 9)  Chimichanga damage, Cost 5 Doubloon   ");
            Console.WriteLine("[E] to [E]xit, [S] to [S]ell");

            string input = Input().ToLower();
            switch (input)
            {
                case "1":
                    if (Player.Wallet >= 5) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(0)); Player.Wallet -= 5; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "2":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(1)); Player.Wallet -= 4; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "3":
                    if (Player.Wallet >= 4) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(2)); Player.Wallet -= 4; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "4":
                    if (Player.Wallet >= 3) { Whale.UpgradeWeapon(Player, Weaps.ElementAt(3)); Player.Wallet -= 3; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "5":
                    if (Player.Wallet >= Items[0].cost) { Player.inventory.Add(Items[0]); Player.Wallet -= Items[0].cost; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "6":
                    if (Player.Wallet >= Items[1].cost) { Player.inventory.Add(Items[1]); Player.Wallet -= Items[1].cost; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "7":
                    if (Player.Wallet >= Items[2].cost) { Player.inventory.Add(Items[2]); Player.Wallet -= Items[2].cost; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "8":
                    if (Player.Wallet >= Items[3].cost) { Player.inventory.Add(Items[3]); Player.Wallet -= Items[3].cost; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money");Thread.Sleep(2500); Shop5(Player); return; }
                case "9":
                    if (Player.Wallet >= 3) { Whale.UpgradeWeapon(Player, chim); Player.Wallet -= 5; Shop5(Player); return; }
                    else { Console.WriteLine("You dont have enough money"); Thread.Sleep(2500); Shop5(Player); return; }
                case "s": { Sell(Player); Shop5(Player); return; }
                default: return;
            }
        }//Whale shop has been moved to shop 5

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
            Console.Write("Doubloon " + Gold);
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

        public static void ShipIntro(Whale Player)
        {
            Console.Clear();

            HUD(Player);

            Console.WriteLine("Ship HUB\n" +
                "1) Shop\n" +
                //"2) Equip weapons\n" +
                "2) Inventory\n" +
                "3) Go to Blowholia Prime\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1": { Shop5(Player); ShipIntro(Player); return; }
                //case "2": { Whale.changeWeapon(Player); ShipIntro(Player); return; }
                case "2": { PlayerInventory(Player); ShipIntro(Player); return; }
                case "3": { break; }

                default:
                    Console.WriteLine("Please choose a destination"); ShipIntro(Player);
                    break;
            }

        }
        public static void Ship1(Whale Player)
        {
           Console.Clear();
            HUD(Player);
            
            Console.WriteLine("Ship HUB\n" +
               "1) Shop\n" +
               //"2) Equip weapons\n" +
               "2) Inventory\n" +
               "3) Go to Atlantis\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1": { Shop3(Player);Ship1(Player); return; }
                //case "2": { Whale.changeWeapon(Player); Ship1(Player); return; }
                case "2": { PlayerInventory(Player); Ship1(Player); return; }
                case "3": { break; }

                        default: Console.WriteLine("Please choose a destination"); Ship1(Player);
                    break;
            }
            
        }
        public static void Ship2(Whale Player)
        {
            Console.Clear();

            HUD(Player);

            Console.WriteLine("Ship HUB\n" +
               "1) Shop\n" +
               //"2) Equip weapons\n" +
               "2) Inventory\n" +
               "3) Go to Coralton\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1": { Shop3(Player); Ship2(Player); return; }
                //case "2": { Whale.changeWeapon(Player); Ship2(Player); return; }
                case "2": { PlayerInventory(Player); Ship2(Player); return; }
                case "3": { break; }

                default:
                    Console.WriteLine("Please choose a destination"); Ship2(Player);
                    break;
            }

        }
        public static void Ship3(Whale Player)
        {
            Console.Clear();

            HUD(Player);

            Console.WriteLine("Ship HUB\n" +
               "1) Shop\n" +
               //"2) Equip weapons\n" +
               "2) Inventory\n" +
               "3) Go to Blubbernot\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1": { Shop3(Player); Ship3(Player); return; }
                //case "2": { Whale.changeWeapon(Player); Ship3(Player); return; }
                case "2": { PlayerInventory(Player); Ship3(Player); return; }
                case "3": { break; }

                default:
                    Console.WriteLine("Please choose a destination"); Ship3(Player);
                    break;
            }

        }
        public static void Ship4(Whale Player)
        {
            Console.Clear();

            HUD(Player);

            Console.WriteLine("Ship HUB\n" +
                "1) Shop\n" +
                //"2) Equip weapons\n" +
                "2) Inventory\n" +
                "3) Go to Marriana Trench\n");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "1": { Shop3(Player); Ship4(Player); return; }
                //case "2": { Whale.changeWeapon(Player); Ship4(Player); return; }
                case "2": { PlayerInventory(Player); Ship4(Player); return; }
                case "3": { break; }

                default:
                    Console.WriteLine("Please choose a destination"); Ship4(Player);
                    break;
            }

        }

        public static void PlayerInventory(Whale Player)
        {
            Console.Clear();

            HUD(Player);
            Console.WriteLine($"{Player.Name}'s Inventory\n");

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
            Console.ReadLine(); 
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

        public static void Goose1(Whale Player)
        {
            Console.Clear();
            HUD(Player);
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
            Console.WriteLine("I'm Bobo the whale, I know what you're thinking...");
            Console.WriteLine("How could I be a whale, well I'll tell you a secret");
            Console.WriteLine("I'm Dolf Lundphin's first and only child, lucky for you I have some pretty nice wears.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            
        }
        public static void Goose2(Whale Player)
        {
            Console.Clear();
            HUD(Player);

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
        public static void Goose3(Whale Player)
        {
            Console.Clear();
            HUD(Player);

            Console.WriteLine("                                                        _...--.");
            Console.WriteLine("                                        _____......----'     .'");
            Console.WriteLine("                                  _..-''                   .'");
            Console.WriteLine("                                .'                       ./");
            Console.WriteLine("                        _.--._.'                       .' |");
            Console.WriteLine("                     .-'                           .-.'  /");
            Console.WriteLine("                   .'   _.-.                     .  \'  '");
            Console.WriteLine("                 .'  .'   .'    _    .-.        / `./  :");
            Console.WriteLine("               .'  .'   .'  .--' `.  |  \' |`. |     .'");
            Console.WriteLine("            _.'  .'   .' `.'       `-'   \'/ |.'   .'");
            Console.WriteLine("         _.'  .-'   .'     `-.            `      .'");
            Console.WriteLine("       .'   .'    .'          `-.._ _ _ _ .-.    :");
            Console.WriteLine("      /    /o _.-'               .--'   .'   \'  |");
            Console.WriteLine("    .'-.__..-'                  /..    .`    / .'");
            Console.WriteLine("  .'   . '                       /.'/.'     /  |");
            Console.WriteLine(" `---'                                   _.'   '");
            Console.WriteLine("                                       /.'    .'");
            Console.WriteLine("                                        /.'/.'");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Welcome back, Stranger. What you buying?");

        }
        public static void Cousin(Whale Player)
        {
            Console.Clear();
            HUD(Player);

            Console.WriteLine("                  _..-''''-.._");
            Console.WriteLine("              _.-'            `-._");
            Console.WriteLine("             /                    \"");
            Console.WriteLine("            :    .-';      ;'-.    :");
            Console.WriteLine("            |   / _.-:    :-._ \'  |"); 
            Console.WriteLine("            :  ; ;  o/    \'o  ; ;  :");
            Console.WriteLine("           /    \'_!-'      '-!_/    \"");
            Console.WriteLine("          :'-..__              __..-':");
            Console.WriteLine("         /       \'           /       \"");
            Console.WriteLine("       .'\'       \'         /        /'.");
            Console.WriteLine("     .'   ;        `-.    .-'        ;   '.");
            Console.WriteLine("    ;     :           '..'           :     ;");
            Console.WriteLine("   :      |         __...__          |      :");
            Console.WriteLine("   ;      |      .-'       `-.       |      ;");
            Console.WriteLine("   :      :     /             \'     :      :");
            Console.WriteLine("  :      /     /               \'     \'     :");
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("Hi! I are Lenard");
            Console.WriteLine("I cover the shop for Bobo, when hes out doing Whale knows what.");
            Console.WriteLine("\nPress ENTER to continue");
            Console.ReadLine();

        }
        public static void Cousin2(Whale Player)
        {
            Console.Clear();
            HUD(Player);

            Console.WriteLine("                  _..-''''-.._");
            Console.WriteLine("              _.-'            `-._");
            Console.WriteLine("             /                    \"");
            Console.WriteLine("            :    .-';      ;'-.    :");
            Console.WriteLine("            |   / _.-:    :-._ \'  |");
            Console.WriteLine("            :  ; ;  o/    \'o  ; ;  :");
            Console.WriteLine("           /    \'_!-'      '-!_/    \"");
            Console.WriteLine("          :'-..__              __..-':");
            Console.WriteLine("         /       \'           /       \"");
            Console.WriteLine("       .'\'       \'         /        /'.");
            Console.WriteLine("     .'   ;        `-.    .-'        ;   '.");
            Console.WriteLine("    ;     :           '..'           :     ;");
            Console.WriteLine("   :      |         __...__          |      :");
            Console.WriteLine("   ;      |      .-'       `-.       |      ;");
            Console.WriteLine("   :      :     /             \'     :      :");
            Console.WriteLine("  :      /     /               \'     \'     :");
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("What would you like to buy?");
        }
        public static void BigWhale(Whale Player)
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
            Console.WriteLine("        Welcome back to the ship, What would you like to buy?");
            Console.WriteLine("___________________________________________________________________________________________");
        }
 

    }
}