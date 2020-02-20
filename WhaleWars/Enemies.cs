using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Enemies : Whale
    {
        public Enemies(string _name, CharClass cc, int _health, int _defense, int _offense)
             :base (_name, cc, _health, _defense, _offense){}

        public  static Enemies EnemyGenerator()
        {
            Random r = new Random();
         int H =  r.Next(20, 35);
         int O = r.Next(3, 7);
         int D = r.Next(4,6);

            Enemies enemy = new Enemies(NameGenerator(), CharClass.fighter,H,D,O);
            return enemy;
        }
        public static string NameGenerator()
        {
            Random r = new Random();
            string[] namegen1 = { "Bowhead", "Bryde", "Minke", "Eden", "Fin", "Omura", "Sei", "Hector", "Long Finn", "Dusky", "Snubfin", "Tucuxi", "Bottlenose", "Narwhal" };
            string[] namegen2 = {"Plague", "Tormented", "Hindered", "Blind", "Haunted", "Killer", "Savage", "Powerfull", "omnipotent", "Loved" };
            int name1 = r.Next(namegen1.Length);
            int name2 = r.Next(namegen2.Length);
            string outname = namegen1[name1] + " "  + "the" + " " + namegen2[name2] + " Whale";
            return outname;

        }

        public static int EnemyAI(Whale user, Enemies target)
        {
            Random r = new Random();
            int ai = r.Next(1, 5);

            switch (ai)
            {
                case 1: return Enemies.EnemyBasicATK(user, target);
                case 2: return Enemies.EnemySmash(user, target);
                case 3: return Enemies.EnemyUnleashedRage(user, target);
                case 4: return Enemies.EnemySyphonLife(user,target);
                
                default: break;
            }

            return 0;
        }

        public static int EnemyBasicATK(Whale user, Enemies target)
        {
            int ed = target.Offense - user.Defense;
            if (ed <= 0) 
            {
                target.Offense += 7;
                Console.WriteLine($"\n{target.Name} Swings his sword and misses, {target.Name} becomes enraged."); return user.Health; 
            }
            
            user.Health -= target.Offense - user.Defense;
            Console.WriteLine($"\n{target.Name} Swings his sword, dealing {ed} damage.");

            return user.Health;
        }
        public static int EnemySmash(Whale user, Enemies target)
        {
            int ed = (target.Offense - user.Defense) + 2;
            if (ed <= 0) 
            {
                target.Offense += 7;
                Console.WriteLine($"\n{target.Name} uses Smash and misses, {target.Name} becomes enraged."); return user.Health; 
            }

            user.Health -= (target.Offense-user.Defense) + 2;
            Console.WriteLine($"\n{target.Name} uses Smash dealing {ed} danage.");

            return user.Health;
        }
        public static int EnemyUnleashedRage(Whale user, Enemies target)
        {
            Console.WriteLine($"\n{target.Name} uses Unleashed Rage, dealing {target.Offense} damage.");
            user.Health -= target.Offense;
            return user.Health;
        }
        public static int EnemySyphonLife(Whale user, Enemies target)
        {
            int ed = (target.Offense - user.Defense) + 2;
            if (ed <= 0)
            {
                target.Offense += 7;
                Console.WriteLine($"\n{target.Name} uses Syphone Life, but the spell misses. {target.Name} becomes enraged"); return user.Health;
            }

            user.Health -= target.Offense - user.Defense;
            target.Health += target.Offense - user.Defense;
            Console.WriteLine($"\n{target.Name} uses Syphone Life, dealing {target.Offense - user.Defense} damage "+
                "and absorbing { target.Offense - user.Defense} health.");
           
            return user.Health;
        }
        
    }
}
