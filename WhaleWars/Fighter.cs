using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WhaleWars
{
    class Fighter
    {
        public static int FighterMoves(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            Console.WriteLine("Select a skill to use\n" +
                "1) Attack   +1 MP\n" +
                "2) Lung     -2 MP\n" +
                "3) Slam     -3 MP\n" +
                "4) Execute  -4 MP\n" +
                "5) Berserk  -4 MP\n" +
                "6} Inventory\n");

            string Input = Console.ReadLine().ToLower();

            switch (Input)
            {
                case "1": { Player.MagicPoints += 1; return Fighter.BasicAtk(Player, target);} 
                case "2": if (Player.MagicPoints >= 2) {Player.MagicPoints -= 2; return Fighter.Lung(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "3": if (Player.MagicPoints >= 3) { Player.MagicPoints -= 3; return Fighter.ShieldSlam(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "4": if (Player.MagicPoints >= 4) { Player.MagicPoints -= 4; return Fighter.Execute(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "5": if (Player.MagicPoints >= 4) { Player.MagicPoints -= 4; return Fighter.Berserk(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "6": if (Player.inventory.Count == 0) { Console.WriteLine($"{Player.Name}: ...I'm out of items."); Thread.Sleep(2500); FighterMoves(Player, target); return 0; }
                    else { Whale.UseItem(Player); return 0; }
                default: return BasicAtk(Player, target);
            }
        }
        public static void OutofMP(Whale Player, Enemies target)
        {
            Console.WriteLine("You do not have enough MP, please select a different skill"); Thread.Sleep(1300);  FighterMoves(Player, target);
        }
        public static int BasicAtk(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            int pd = Player.Offense - target.Defense;
            target.Health -= (Player.Offense - target.Defense);
            Console.WriteLine($"You hastely attack with your {Player.EquipedWeapon[0].Name} dealing {pd} to {target.Name}");

            return target.Health;
        }
        public static int Lung(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            int pd = (Player.Offense - target.Defense) + 1;
            target.Health -= (Player.Offense - target.Defense) + 1;

            Console.WriteLine($"You thrust your {Player.EquipedWeapon[0].Name} dealing {pd} to {target.Name}");            

            return target.Health;
        }
        public static int Berserk(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            target.Health -= (Player.Offense + 5);
            Player.Health -= 2;

            Console.WriteLine($"You charge {target.Name}, sacraficing 5 health to do {Player.Offense + 5} damage ");

            return target.Health;
        }
        public static int Execute(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            if (target.Health == target.Health/2) 
            {
                Console.WriteLine($"You draw all your might, destroying {target.Name}");
                target.Health -= target.Health;

                return target.Health; 
            }
            else 
            {
                Console.WriteLine($"You draw all your might attempting to destroying {target.Name}.  ");
                target.Health -= (Player.Offense + 1);

                return target.Health;  
            }
        }
        public static int ShieldSlam(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            target.Health -= (Player.Defense - target.Defense);
            Console.WriteLine($"You bash your weapon against {target.Name}, dealing {Player.Defense - target.Defense} damage");

            return target.Health;
        }        
    }
}
