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
        public Weapon weapon;


        public Human(int Health, int Damage, int Resistance, int ArmorID, int WeaponID)
        {
            this.Damage = Damage;
            this.Resistance = Resistance;
            armor = new Armor(ArmorID);
            weapon = new Weapon(WeaponID);
            currentHealth = Health;
        }

    }
}
