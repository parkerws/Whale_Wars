using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WhaleWars
{
    public class Enemies : Whale
    {
        public Enemies(string _name, CharClass cc, int _health, int _defense, int _offense, int magicpoints)
             :base (_name, cc, _health, _defense, _offense, magicpoints){}

        public  static Enemies EnemyGenerator()
        {
            Random r = new Random();
         int H =  r.Next(20, 35);
         int O = r.Next(3, 7);
         int D = r.Next(4,6);

            Enemies enemy = new Enemies(NameGenerator(), CharClass.fighter,H,D,O, 10);
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

        public static int EnemyAI(Whale Player, Enemies target)
        {
            Random r = new Random();
            int ai = r.Next(1, 5);

            switch (ai)
            {
                case 1: return EnemyBasicATK(Player, target);
                case 2: return EnemySmash(Player, target);
                case 3: return EnemyUnleashedRage(Player, target);
                case 4: return EnemySyphonLife(Player,target);
                
                default: break;
            }

            return 0;
        }
        public static int LundfinAI(Whale Player, Enemies target)
        {
            Random r = new Random();
            int ai = r.Next(1, 6);

            switch (ai)
            {
                case 1: return EnemyBasicATK(Player, target);
                case 2: return EnemySmash(Player, target);
                case 3: return EnemyUnleashedRage(Player, target);
                case 4: return EnemySyphonLife(Player, target);
                case 5: return SpawnMinion(Player,target);
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
            
            user.Health -= (target.Offense - user.Defense);
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
            Console.WriteLine($"\n{target.Name} uses Smash dealing {ed} damage.");

            return user.Health;
        }
        public static int EnemyUnleashedRage(Whale Player, Enemies target)
        {
            int ed = (target.Offense - Player.Defense);
            if (ed <= 0)
            {
                Console.WriteLine($"\n{target.Name} Unleashes Rage, increasing base ATK by 5");
                target.Offense += 5;
                return target.Offense;
            }
            Console.WriteLine($"\n{target.Name} Unleashes Rage, increasing base ATK by 3 and dealing {target.Offense - Player.Defense} damage.");
            target.Offense += 3;
            Player.Health -= (target.Offense - Player.Defense);
            return Player.Health;
        }
        public static int EnemySyphonLife(Whale user, Enemies target)
        {
            int ed = (target.Offense - user.Defense);
            if (ed <= 0)
            {
                target.Offense += 7;
                Console.WriteLine($"\n{target.Name} uses Syphone Life, but the spell misses. {target.Name} becomes enraged"); return user.Health;
            }

            user.Health -= target.Offense - user.Defense;
            target.Health += target.Offense - user.Defense;

            Console.WriteLine($"\n{target.Name} uses Syphone Life, dealing {ed} damage "+
                $"and absorbing {ed} health.");
           
            return user.Health;
        }
        public static int SpawnMinion(Whale Player, Enemies target)
        {
            Console.Clear();
            ConsoleInterface.HUD(Player);

            Enemies target2 = EnemyGenerator();

            Console.WriteLine($"{target.Name} Yells: I NEED HELP! {target2.Name} rushes you from out of the shadows.");

            Thread.Sleep(2000);

            Combat.Battle(Player, target, target2);
            return 0;
        } //boss move used to add another monster into combat. 3 person Combat WOOO! 
    }
}
