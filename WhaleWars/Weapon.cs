using System;
using System.Linq;
namespace WhaleWars
{
    public class Weapon
    {
        public WeaponList Name { get; set; } // instead of string, use enum for more efficiency
        public int Damage { get; set; }
        public int Defense { get; set; }

        public Weapon(WeaponList weapon, int damage, int defense)  // Constructor needs these 3 parameters to create. This is only used for the CreateWeapons() method.
        {
            this.Name = weapon;
            this.Damage = damage;
            this.Defense = defense;
        }

        public static Weapon CreateWeapon(WeaponList weap) //Method that uses a list of type Weapon to create all weapons necessary for the game.
        {
            switch (weap)
            {
                case WeaponList.Sword:
                    Weapon Sword = new Weapon(weap, 6, 4);
                    return Sword;

                case WeaponList.Knife:
                    Weapon Knife = new Weapon(weap, 7, 3);
                    return Knife;

                case WeaponList.Bow:
                    Weapon Bow = new Weapon(weap, 2, 8);
                    return Bow;

                case WeaponList.Blowhole:
                    Weapon Blowhole = new Weapon(weap, 9, 1);
                    return Blowhole;

                case WeaponList.Chimichanga:
                    Weapon Chimichanga = new Weapon(weap, 8, 2);
                    return Chimichanga;

                case WeaponList.Wand:
                    Weapon Wand = new Weapon(weap, 5, 5);
                    return Wand;

                case WeaponList.UltraBoof:
                    Weapon UltraBoof = new Weapon(weap, 10, 10);
                    return UltraBoof;

                default:
                    return null;
            }
        }

        public static Weapon WeaponGen()
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
            int wo = r.Next(1, 10);
            

            Weapon FWeap = new Weapon(0, wo, 0);
            Weapon MWeap = new Weapon(0, wo, 0);
            Weapon RWeap = new Weapon(0, wo, 0);


            return FWeap;
        } //altered to fit the Get; Set; variables, doesnt produce a name.. work in progress.
    }
}