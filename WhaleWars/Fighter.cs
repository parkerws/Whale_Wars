using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Fighter
    {
        public static int FighterMoves(Whale user, Enemies target)
        {
            Console.WriteLine("Select a skill to use\n" +
                "1) Lung\n" +
                "2) Berserk\n" +
                "3) Execute\n" +
                "4) ShieldSlam\n");

            int Input = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case int n when n == 1: return Fighter.Lung(user, target);
                case int n when n == 2: return Fighter.ShieldSlam(user, target);
                case int n when n == 3: return Fighter.Execute(user, target);
                case int n when n == 4: return Fighter.Berserk(user);
                default: break;
            }

            return BasicAtk(user, target);
        }
        public static int BasicAtk(Whale user, Enemies target)
        {
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        }
        public static int Lung(Whale user, Enemies target)
        {
            target.Health -= (user.Offense - target.Defense) + 1;
            return target.Health;
        }
        public static int Berserk(Whale user)
        {
            user.Offense += 2;
            user.Defense -= 2;
            return user.Offense;
        }
        public static int Execute(Whale user, Enemies target)
        {
            double percent = (target.Health / 10);
            if (percent == 0.4) { target.Health -= target.Health; return target.Health; }
            else { target.Health -= (user.Offense + 1); return target.Health;  }
        }
        public static int ShieldSlam(Whale user, Enemies target)
        {
            target.Health -= user.Defense;
            return target.Health;
        }
    }
}
