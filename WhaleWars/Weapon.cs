using System;
using WhaleWars;

namespace WhaleWars
{
    public class Weapon : Item
    {
        
        public int Damage { get; set; }
        
        public Weapon(string weapon, int damage)  // Constructor needs these 3 parameters to create. This is only used for the CreateWeapons() method.
        {
            Name = weapon;
            Damage = damage;            
        }

        public Weapon()
        {
            Name = "Will's Mustache";
            Damage = 0;
        }

        //public static Weapon CreateWeapon(WeaponList weap) //Method that uses a list of type Weapon to create all weapons necessary for the game.
        //{
        //    switch (weap)
        //    {
        //        case WeaponList.Sword:
        //            Weapon Sword = new Weapon(weap, 6);
        //            return Sword;

        //        case WeaponList.Knife:
        //            Weapon Knife = new Weapon(weap, 7);
        //            return Knife;

        //        case WeaponList.Bow:
        //            Weapon Bow = new Weapon(weap, 2);
        //            return Bow;

        //        case WeaponList.Blowhole:
        //            Weapon Blowhole = new Weapon(weap, 9);
        //            return Blowhole;

        //        case WeaponList.Chimichanga:
        //            Weapon Chimichanga = new Weapon(weap, 8);
        //            return Chimichanga;

        //        case WeaponList.Wand:
        //            Weapon Wand = new Weapon(weap, 5);
        //            return Wand;

        //        case WeaponList.UltraBoof:
        //            Weapon UltraBoof = new Weapon(weap, 10);
        //            return UltraBoof;

        //        default:
        //            return null;
        //    }
        //}

        public static Weapon WeaponGen(Whale Player)
        {
            Random r = new Random();
            string[] FighterWeapons = { "Sword", "Mace", "Butcher Knife", "Bottle Opener", "Club", "Pan", "Golf Club", "Halberd", "Long Sword", "God Sword" };
            string[] MageWeapons = { "Arcanists Wand", "Wicked One's Staff", "Oracle", "Necronomicon", "Witches Spellbook", "Stick", "Old Man Cane" };
            string[] RangerWeapons = { "Arcane Bow", "Toxic Bow", "Fire Bow", "Ice Bow", "Lightning Bow", "Sling-Shot", "Nerf Gun", "Golden Gun", "Long Straw" };
            int fw = r.Next(FighterWeapons.Length);
            int mw = r.Next(MageWeapons.Length);
            int rw = r.Next(RangerWeapons.Length);
            string fwn = FighterWeapons[fw];
            string mwn = MageWeapons[mw];
            string rwn = RangerWeapons[rw];
            int wo = r.Next(1, 11);
            if (Player.CC == CharClass.fighter) { Weapon FWeap = new Weapon(fwn, wo); return FWeap; }
            if (Player.CC == CharClass.mage) { Weapon MWeap = new Weapon(mwn, wo); return MWeap; }
            if (Player.CC == CharClass.ranger) { Weapon RWeap = new Weapon(rwn, wo); return RWeap; }
            else {return null; }            
        } //altered to fit the Get; Set; variables, doesnt produce a name.. work in progress.
    }

    public class Sword : Weapon
    {
        public Sword() : base()
        {
            Name = "Sword";
            Damage = 6;
        }
    } 
    public class Knife : Weapon
    {
        public Knife() : base()
        {
            Name = "Knife";
            Damage = 7;
        }
    }
    public class Bow : Weapon
    {
        public Bow() : base()
        {
            Name = "Bow";
            Damage = 2;
        }
    }
    public class Blowhole : Weapon
    {
        public Blowhole() : base()
        {
            Name = "Blowhole";
            Damage = 22;
        }
    }
    public class Chimichanga : Weapon
    {
        public Chimichanga() : base()
        {
            Name = "Chimichanga";
            Damage = 55;
        }
    }
    public class Wand : Weapon
    {
        public Wand() : base()
        {
            Name = "Wand";
            Damage = 5;
        }
    }
    public class UltraBoof : Weapon
    {
        public UltraBoof() : base()
        {
            Name = "UltraBoof";
            Damage = 32;
        }
    }
    public class Fork : Weapon
    {
        public Fork() : base()
        {
            Name = "Mind Fork of Endless Suffering";
            Damage = 75;
        }
    }

}