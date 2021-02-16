﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => 0.35;

        public override ICollection<Type> PreferredFoods =>
           new List<Type>() { typeof(Meat), typeof(Seeds), typeof(Vegetable)
           , typeof(Fruit)};

        public override string IAskForFood()
        {
            return "Cluck";
        }
    }
}
