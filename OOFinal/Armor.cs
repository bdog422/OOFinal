using System;
using System.Collections.Generic;
using System.Text;


namespace Engine
{
    public class Armor  
    {
        public string ArmorName { get; set; }
        public int ArmorID { get; set; }
        public int AddedResistance { get; set; }


        public void ArmorStats(int ID)
        {
            ArmorID = ID;
            if(ID == 0)
            {
                ArmorName = "Nothing";
                AddedResistance = 0;
            }
            if(ID == 1)
            {
                ArmorName = "Gauntlets";
                AddedResistance = 50;
            }
            if(ID == 2)
            {
                ArmorName = "Helmet";
                AddedResistance = 20;
            }
            if(ID == 3)
            {
                ArmorName = "Total Protection";
                AddedResistance = 70;
            }
        }
    }
}
