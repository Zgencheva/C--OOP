﻿using System;
using Moq;

namespace MockingAndTestDrivenDepelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mock<Promotion> mockPromotion = new Mock<Promotion>();
            mockPromotion.Setup(m => m.Get()).Returns(20);
            mockPromotion.Setup(m => m.CalculateDiscount(100))
                .Returns(90);
            Console.WriteLine($"Get discount %: " +
                $"{mockPromotion.Object.Get()}");
            Console.WriteLine($"Get discount(100): " +
                $"{mockPromotion.Object.CalculateDiscount(100)}");
            //Promotion promotion = new Promotion(DateTime.Now);
            //Console.WriteLine(promotion.CalculateDiscount(100));
        }
    }
}
