using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon
    {
        public string WeaponName { get; set; }
        public int WeaponID { get; set; }
        public int AddedDamage { get; set; }

        public Weapon(int ID)
        {
            WeaponID = ID;
            if(ID == 0)
            {
                WeaponName = "None";
                AddedDamage = 0;
            }
            if (ID == 1)
            {
                WeaponName = "Dagger";
                AddedDamage = 20;
            }
            if(ID == 2)
            {
                WeaponName = "Ring of Strength";
                AddedDamage = 40;
            }
            if(ID == 3)
            {
                WeaponName = "Wisdom of the Ancients";
                AddedDamage = 10;
            }
            if(ID == 4)
            {
                WeaponName = "Total Package";
                AddedDamage = 70;
            }
        }
    }
}
