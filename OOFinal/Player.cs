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

        public Player(int Health, int Damage, int Resistance) : base(Health, Damage, Resistance)
        {
            Karma = 0;
        }
    }
}
