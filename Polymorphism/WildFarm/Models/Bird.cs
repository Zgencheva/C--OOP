﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; set; }
        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
