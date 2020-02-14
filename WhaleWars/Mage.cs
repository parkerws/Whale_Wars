using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    class Mage
    {
        //Methods used to represent a Mage spell as damage to a target.
        public static int MageMoves(Whale user, Whale target)
        {
            Console.WriteLine("Select a skill to use\n" +
                "1) Magic Missle\n" +
                "2) Fire Ball\n" +
                "3) Blood Syphon\n" +
                "4) ArcaneShield");

            int Input = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case int n when n == 1: return Mage.MagicMissle(user, target);
                case int n when n == 2: return Mage.FireBall(user, target);
                case int n when n == 3: return Mage.BloodSyphon(user, target);
                case int n when n == 4: return Mage.ArcaneShield(user);
                default: break;
            }

            return Mage.Wand(user, target);
        } //Allows the user to pick a skill           
        public static int Wand(Whale user, Whale target)
        {
            target.Health -= (user.Offense - target.Defense);
            return target.Health;
        } //Basic attack                                  
        public static int MagicMissle(Whale user, Whale target)
        {
            target.Health -= user.Offense;
            return target.Health;
        } //Deals more damage than basic attack    
        public static int FireBall(Whale user, Whale target)
        {
            target.Health -= (user.Offense + 2);
            return target.Health;
        } //Deals more damage than Magic Missle       
        public static int BloodSyphon(Whale user, Whale target)
        {
            target.Health -= user.Offense;
            user.Health += user.Offense;
            return target.Health;
        } //Deals damage and absorbes health        
        public static int ArcaneShield(Whale user)
        {
            Console.WriteLine("You are surrounded with a purple barrier.");
            user.Defense += 20;
            return user.Defense;
        } //Increases Defense                                  
        
    }
}
