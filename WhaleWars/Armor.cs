using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Armor : Item
    {
        public CharClass charClass;
        public int defense { get; set; }
        public Armor(string name, int def, CharClass classClass)
        {
            Name = name;
            charClass = classClass;
            defense = def;           
        }

        public Armor()
        {
            Name = "melvin";
            charClass = CharClass.fighter;
            defense = 0;
        }
    }

    public class Plating : Armor
    {
        public Plating() : base()
        {
            Name = "Bobby Blow's Bronze Armour";
            charClass = CharClass.fighter;
            defense = 10;
        }
    }

    public class Chainmail : Armor
    {
        public Chainmail() : base()
        {
            Name = " Silver Glittery Rainacorn Scales";
            charClass = CharClass.ranger;
            defense = 2;
        }
    }
     
    public class Cloth : Armor
    {
        public Cloth() : base()
        {
            Name = "Reptilian Magical Cloth";
            charClass = CharClass.mage;
            defense = 5;
        }
    }

}
