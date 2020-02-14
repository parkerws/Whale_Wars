using System;
using System.Threading;

namespace WhaleWars
{
	public class Combat
	{
        
        //Used as a test battle between two entities.
        public static void Battle(Whale user, Whale target)
        {
            //This section is only used for the HUD location. 
            Planet sumPlanet = new Planet("Blowholia Prime", PlanetType.ocean, 5, 4, Sector.Blowholia);
            string Location = sumPlanet.Name;                                                          
            int turn = 0;                                                                              
         

            //While loop used to simulate a fight.
            while (user.Health > 0 && target.Health > 0)                                                  
            {                                                                                             
                ConsoleInterface.HUD(user.Name, Location, turn, user.Health, user.Offense, user.Defense);
                if (user.CC == CharClass.mage) { Mage.MageMoves(user, target); }
                if (user.CC == CharClass.fighter) { Fighter.FighterMoves(user, target); }
                if (user.CC == CharClass.ranger) { Ranger.RangerMoves(user, target); }
                Thread.Sleep(2300);                                                                       
                ConsoleInterface.HUD(user.Name, Location, turn, user.Health, user.Offense, user.Defense); 
                EnemyAI(target, user);                                                                    
            }                                                                                             
           
        }       
               
        public static int EnemyAI(Whale user, Whale target)
        {
            Random r = new Random();
            int ai = r.Next(1, 5);

            switch (ai)
            {
                case int n when n == 1: return Mage.MagicMissle(user, target);
                case int n when n == 2: return Mage.FireBall(user, target);
                case int n when n == 3: return Mage.BloodSyphon(user, target);
                case int n when n == 4: return Mage.ArcaneShield(user);
                default: break;
            }

            return Mage.Wand(user, target);
        }
    }
}

