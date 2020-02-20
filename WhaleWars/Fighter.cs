using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Fighter
    {
        public static int FighterMoves(Whale Player, Enemies target)
        {
            Console.WriteLine("Select a skill to use\n" +
                "1) Attack +1 MP\n" +
                "2) Lung -2 MP\n" +
                "3) Slam -3 MP\n" +
                "4) Execute -4 MP\n" +
                "5) Berserk -4 MP\n");

            int Input = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case 1: return Fighter.BasicAtk(Player, target);
                case 2: return Fighter.Lung(Player, target);
                case 3: return Fighter.ShieldSlam(Player, target);
                case 4: return Fighter.Execute(Player, target);
                case 5: return Fighter.Berserk(Player, target);
                default: return BasicAtk(Player, target);
            }
        }
        public static int BasicAtk(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            int pd = Player.Offense - target.Defense;
            target.Health -= (Player.Offense - target.Defense);
            Console.WriteLine($"You swing your {Player.EquipedWeapon[0].Name} dealing {pd} to {target.Name}");

            Player.MagicPoints += 1;

            return target.Health;
        }
        public static int Lung(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            int pd = (Player.Offense - target.Defense) + 1;
            target.Health -= (Player.Offense - target.Defense) + 1;

            Console.WriteLine($"You thrust your {Player.EquipedWeapon[0].Name} dealing {pd} to {target.Name}");

            Player.MagicPoints -= 2;
            if (Player.MagicPoints <= 0) { Player.MagicPoints = 0; }

            return target.Health;
        }
        public static int Berserk(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            target.Health -= (Player.Offense + 5);
            Player.Health -= 2;

            Console.WriteLine($"You charge {target.Name}, sacraficing 5 health to do {Player.Offense + 5} damage ");

            Player.MagicPoints -= 4;
            if (Player.MagicPoints <= 0) { Player.MagicPoints = 0; }

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

                Player.MagicPoints -= 4;
                if (Player.MagicPoints <= 0) { Player.MagicPoints = 0; }

                return target.Health; 
            }
            else 
            {
                Console.WriteLine($"You draw all your might attempting to destroying {target.Name}.  ");
                target.Health -= (Player.Offense + 1);

                Player.MagicPoints -= 4;
                if (Player.MagicPoints <= 0) { Player.MagicPoints = 0; }

                return target.Health;  
            }
        }
        public static int ShieldSlam(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            target.Health -= (Player.Defense - target.Defense);
            Console.WriteLine($"You bash your weapon against {target.Name}, dealing {Player.Defense - target.Defense} damage");

            Player.MagicPoints -= 3;
            if (Player.MagicPoints <= 0) { Player.MagicPoints = 0; }

            return target.Health;
        }

        
    }
}
