using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Human
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Resistance { get; set; }
        public int currentHealth { get; set; }
        public Armor armor;
        public Weapons weapon;


        public Human(int Health, int Damage, int Resistance, int ArmorID, int WeaponID)
        {
            this.Damage = Damage;
            this.Resistance = Resistance;
            armor = new Armor();
            weapon = new Weapons();
            armor.ArmorStats(ArmorID);
            weapon.WeaponStats(WeaponID);
            currentHealth = Health;
        }

    }
}
