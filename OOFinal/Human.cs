﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Human
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Resistance { get; set; }


        public Human(int Health, int Damage, int Resistance)
        {
            Health = 100;
            Damage = 20;
            Resistance = 10;
        }

    }
}