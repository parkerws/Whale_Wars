using System;
using WhaleWars;

namespace WhaleWars
{

    public class Item
    {
        public string Name { get; set; }
        public int cost { get; set; }
        public int attributeIncrease { get; set; }

        public Item()
        {
            Name = "Sven";
            cost = 2;
            attributeIncrease = 10;
        }

        public static Item ItemGen(string itemType)
        {
        Random r = new Random();

        string[] HealthItems =
        {
            "Health Potion"
        };

        string[] ArmorItems =
        {
            "Armor Buff"
        };

        string[] MagicItems =
        {
            "Magic Potion"
        };


        int healthItem = r.Next(HealthItems.Length);
        int armorItem = r.Next(ArmorItems.Length);
        int magicItem = r.Next(MagicItems.Length);


        string hItem = HealthItems[healthItem];
        string aItem = ArmorItems[armorItem];
        string mItem = MagicItems[magicItem];

            if (itemType == "health")
        {
            HealthPotion healthPotion = new HealthPotion(hItem);
            return healthPotion;
        }

        else if (itemType == "armor")
        {
            ArmorPotion armorPotion = new ArmorPotion(aItem);
            return armorPotion;
        }

        else if (itemType == "magic")
        {
            MagicPotion magicPotion = new MagicPotion(mItem);
            return magicPotion;
        }

        else
        {
            return null;
        }

    }
}


    public class HealthPotion : Item
    {
        public HealthPotion(string name) : base()
        {
            Name = name;
            cost = 2;
            attributeIncrease = 20;
        }
    }
    public class ArmorPotion : Item
    {
        public ArmorPotion(string name) : base()
        {
            Name = name;
            cost = 7;
            attributeIncrease = 5;
        }
    }
    public class MagicPotion : Item
    {
        public MagicPotion(string name) : base()
        {
            Name = name;
            cost = 3;
            attributeIncrease = 12;
        }
    }


} 