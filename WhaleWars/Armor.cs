using System;
using System.Collections.Generic;
using System.Text;

namespace WhaleWars
{
    public class Armor : Item
    {   
        public int defense { get; set; }
        public Armor(string name, int def)
        {
            Name = name;            
            defense = def;           
        }

        public Armor()
        {
            Name = "melvin";           
            defense = 0;
        }
    }

    public class Plating : Armor
    {
        public Plating() : base()
        {
            Name = "Bobby Blow's Bronze Armour";          
            defense = 10;
        }
    }

    public class Chainmail : Armor
    {
        public Chainmail() : base()
        {
            Name = " Silver Glittery Rainacorn Scales";           
            defense = 5;
        }
    }
     
    public class Cloth : Armor
    {
        public Cloth() : base()
        {
            Name = "Reptilian Magical Cloth";          
            defense = 2;
        }
    }

}
