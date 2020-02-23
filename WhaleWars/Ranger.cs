using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WhaleWars
{
    class Ranger
    {
        public static int RangerMoves(Whale Player, Enemies target)
        {

            Console.Clear();
            ConsoleInterface.HUD(Player);

            Console.WriteLine("Select a skill to use\n" +
                "1) Attack          MP +2\n" +
                "2) Pierce          MP -2\n" +
                "3) Multi Attack    MP -4\n" +
                "4) Crippling Blow  MP -2\n" +
                "5) Shadow Step     MP -3\n");

            string Input = Console.ReadLine().ToLower();

            switch (Input)
            {
                case "1": {  Player.MagicPoints += 2; return Fighter.BasicAtk(Player, target); }
                case "2": if (Player.MagicPoints >= 2) { Player.MagicPoints -= 2; return Pierce(Player, target); }
                    else {OutofMP(Player, target); return 0;}
                case "3": if (Player.MagicPoints >= 4) { Player.MagicPoints -= 4; return Multiattack(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "4": if (Player.MagicPoints >= 2) { Player.MagicPoints -= 2; return CriplingBlow(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "5": if (Player.MagicPoints >= 3) { Player.MagicPoints -= 3; return ShadowStep(Player, target); }
                    else { OutofMP(Player, target); return 0; }
                case "6": if (Player.inventory.Count == 0) { Console.WriteLine("You have no more items to use."); Thread.Sleep(2500); RangerMoves(Player, target); return 0; }
                    else { Whale.UseItem(Player); return 0; }
                default: return Fighter.BasicAtk(Player, target);
            }                       
        }
        public static void OutofMP(Whale Player, Enemies target)
        {
            Console.WriteLine("You do not have enough MP, please select a different skill"); Thread.Sleep(1300); RangerMoves(Player, target);
        }
        public static int Pierce(Whale user, Enemies target)
        {
            Console.WriteLine($"You deliver a blow that penetrates the {target.Name}'s armor dealing {user.Offense} damage");
            target.Health -= user.Offense;
            return target.Health;
        }
        public static int Multiattack(Whale user, Enemies target)
        {
            int pd = ((user.Offense * 3) - target.Defense);

            Console.WriteLine($"you deliver multiple attacks to {target.Name}, dealing {pd} damage");

            target.Health -= ((user.Offense *2)- target.Defense);
            return target.Health;
        }
        public static int CriplingBlow(Whale user, Enemies target)
        {
            Console.WriteLine($"You hit so hard that you reduce {target.Name} armor by 1 and deal {(user.Offense - target.Defense)} damage ");

            target.Defense -= 1;
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        }
        public static int ShadowStep(Whale Player, Enemies target)
        {
            target.Health -= (Player.Offense * 2);

            Console.WriteLine($"You disappear into the void, showing up behind {target.Name} and deal {(Player.Offense * 2)} damage");
            return target.Health;
        }

    }
}
