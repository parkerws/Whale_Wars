using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Ranger
    {
        public static int RangerMoves(Whale user, Enemies target)
        {
            Console.WriteLine("Select a skill to use\n" +
                "1) Piercing Shot\n" +
                "2) MultiShot\n" +
                "3) Crippling Blow\n" +
                "4) Shadow Dance\n");

            int Input = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case int n when n == 1: return Ranger.PiercingShot(user, target);
                case int n when n == 2: return Ranger.MultiShot(user, target);
                case int n when n == 3: return Ranger.CriplingBlow(user, target);
                case int n when n == 4: return Ranger.ShadowDance(user);
                default: return Ranger.BasicAtk(user, target);
            }                       
        }
        public static int BasicAtk(Whale user, Enemies target)
        {
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        }
        public static int PiercingShot(Whale user, Enemies target)
        {
            target.Health -= user.Offense;
            return target.Health;
        }
        public static int MultiShot(Whale user, Enemies target)
        {
            target.Health -= ((user.Offense *2)- target.Defense);
            return target.Health;
        }
        public static int CriplingBlow(Whale user, Enemies target)
        {
            target.Defense -= 1;
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        }
        public static int ShadowDance(Whale user)
        {
            user.Defense -= 1;
            user.Health += 10;
            return user.Health;
        }

    }
}
