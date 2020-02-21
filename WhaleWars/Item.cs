using System;
using WhaleWars;

namespace WhaleWars
{

    public class Item
    {
        public string Name { get; set; }
        public int cost { get; set; }
        public int attributeIncrease { get; set; }



        public static Item ItemGen(string itemType)
        {
        Random r = new Random();

        string[] HealthItems =
        {
            "Fat Slug", "Donkey Teeth", "Ibrahim Moizoos' Bubblegum", "Hardunkichud's Cereal"
        };

        string[] ArmorItems =
        {
            "Smoochie-Wallace Dinner Plate", "D'Jasper Probincrux Raincoat Juice",
            "Davoin Shower-Handel's Secret Helmet Sweat", "Quatro Quatro's Thick Skin Serum"
        };

        string[] MagicItems =
        {
            "Saggitariutt Jefferspin's Chapstick", "Hingle McCringleberry's Super Serum",
            "Scoisch \"Velociraptor\" Maloish's Popcorn", "Beezer Twelve Washingbeard's Grand Soup"
        };


        int healthItem = r.Next(HealthItems.Length);
        int armorItem = r.Next(ArmorItems.Length);
        int magicItem = r.Next(MagicItems.Length);


        string hItem = HealthItems[healthItem];
        string aItem = ArmorItems[armorItem];
        string mItem = MagicItems[magicItem];

        int wo = r.Next(1, 4);


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
            cost = 5;
            attributeIncrease = 5;
        }
    }
    public class ArmorPotion : Item
    {
        public ArmorPotion(string name) : base()
        {
            Name = name;
            cost = 7;
            attributeIncrease = 7;
        }
    }
    public class MagicPotion : Item
    {
        public MagicPotion(string name) : base()
        {
            Name = name;
            cost = 7;
            attributeIncrease = 7;
        }
    }


} 