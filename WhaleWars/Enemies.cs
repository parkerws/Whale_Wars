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
         int H =  r.Next(10, 21);
         int O = r.Next(1, 5);
         int D = r.Next(1,6);

            Enemies enemy = new Enemies(NameGenerator(), CharClass.fighter,H,D,O);
            return enemy;
        }
        public static string NameGenerator()
        {
            Random r = new Random();
            string[] namegen1 = { "Bowhead ", "Bryde's "};
            string[] namegen2 = {"Plague ", "Tormented ", "Hindered " };
            int name1 = r.Next(namegen1.Length);
            int name2 = r.Next(namegen2.Length);
            string outname = namegen1[name1] + "Whale " + "the" + " " + namegen2[name2];
            return outname;

        }
    }
}
