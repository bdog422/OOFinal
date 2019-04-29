using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Player : Human
    {
        public int Karma { get; set; }
        public string Name { get; set; }

        public Player(int Health, int Damage, int Resistance, int ArmorID, int WeaponID) : base(Health, Damage, Resistance, ArmorID, WeaponID)
        {
            Karma = 0;
            Damage = 20;
            Resistance = 10;
        }
    }
}
