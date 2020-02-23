using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WhaleWars
{
    class Mage
    {
        //Methods used to represent a Mage spell as damage to a target.
        public static int MageMoves(Whale Player, Enemies target)
        {

            Console.Clear();
            ConsoleInterface.HUD(Player);

            Console.WriteLine("Select a skill to use\n" +
                "1) Attack          MP +3\n"+
                "2) Magic Missle    MP -2\n" +
                "3) Fire Ball       MP -3\n" +
                "4) Blood Syphon    MP -5\n" +
                "5) Arcane Blast    MP -4\n" +
                "6) Inventory\n");

            string Input = Console.ReadLine().ToLower();

            switch (Input)
            {
                case "1": { Player.MagicPoints += 3; return Fighter.BasicAtk(Player, target); }
                case "2": if (Player.MagicPoints >= 2) { Player.MagicPoints -= 2; return MagicMissle(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "3": if (Player.MagicPoints >= 3) { Player.MagicPoints -= 3; return FireBall(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "4": if (Player.MagicPoints >= 5) { Player.MagicPoints -= 5; return BloodSyphon(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "5": if (Player.MagicPoints >= 4) { Player.MagicPoints -= 4; return ArcaneBlast(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "6": if (Player.inventory.Count == 0) { Console.WriteLine("You have no more items to use."); Thread.Sleep(2500); MageMoves(Player, target); return 0; }
                    else { Whale.UseItem(Player); return 0; }
                default: break;
            }

            return Fighter.BasicAtk(Player, target);
        } //Allows the user to pick a skill
        public static void OutofMP(Whale Player, Enemies target)
        {
            Console.WriteLine("You do not have enough MP, please select a different skill"); Thread.Sleep(1300); MageMoves(Player, target);
        }
                                       
        public static int MagicMissle(Whale Player, Enemies target)
        {
            target.Health -= Player.Offense + 5;

            Console.WriteLine($"You shoot a powerfull missle out of tail, dealing {Player.Offense + 5} to {target.Name}");

            return target.Health;
        } //Deals more damage than basic attack    
        public static int FireBall(Whale Player, Enemies target)
        {
            target.Health -= (Player.Offense * 3);

            Console.WriteLine($"You shoot a massive fireball, dealing {Player.Offense} to {target.Name}");

            return target.Health;
        } //Deals more damage than Magic Missle       
        public static int BloodSyphon(Whale Player, Enemies target)
        {
            target.Health -= Player.Offense;
            Player.Health += Player.Offense/2;

            Console.WriteLine($"Blood runs down {target.Name} and pools around you.\n" +
                $"You absorbe {target.Name} essence dealing {Player.Offense} damage and gaining {Player.Offense/2} life");

            return target.Health;
        } //Deals damage and absorbes health        
        public static int ArcaneBlast(Whale Player, Whale target)
        {
            Console.WriteLine($"Arcane explodes from your tail, dealing {Player.Offense * 5} to {target.Name}");
            target.Health -= (Player.Offense * 5);
            return target.Health;
        } //deals all the damage                             
        
    }
}
