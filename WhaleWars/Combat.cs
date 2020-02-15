using System;
using System.Threading;

namespace WhaleWars
{
	public class Combat
	{
        //Used as a test battle between two entities.
        public static void Battle(Whale user, Enemies target)
        {
            //This section is only used for the HUD location. 
            Planet sumPlanet = new Planet("Blowholia Prime", PlanetType.ocean, 5, 4, Sector.Blowholia);
            string Location = sumPlanet.Name;
            int turn = 0;


            //While loop used to simulate a fight.
            while (user.Health > 0 || target.Health > 0)                                                  
            {                                                                                             
                ConsoleInterface.HUD(user.Name, Location, turn, user.Health, user.Offense, user.Defense);
                if (user.CC == CharClass.mage) { Mage.MageMoves(user, target); }
                if (user.CC == CharClass.fighter) { Fighter.FighterMoves(user, target); }
                if (user.CC == CharClass.ranger) { Ranger.RangerMoves(user, target); }
<<<<<<< HEAD
                //Thread.Sleep(1700);
                //if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                //if (target.Health <= 0) { break; }
                //ConsoleInterface.HUD(user.Name, Location, turn, user.Health, user.Offense, user.Defense); 
=======
                Thread.Sleep(1700);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { ConsoleInterface.WinArt(target); break; }
                ConsoleInterface.HUD(user.Name, Location, turn, user.Health, user.Offense, user.Defense); 
>>>>>>> b0408e7eceb0492947166137e893d6e81caa64db
                Enemies.EnemyAI(user, target);
                Thread.Sleep(2500);
                if (user.Health <= 0) { ConsoleInterface.PlayerDied(user, target); }
                if (target.Health <= 0) { ConsoleInterface.WinArt(target); break; }
            }                                                                                             
           
        }                            
    }
}

