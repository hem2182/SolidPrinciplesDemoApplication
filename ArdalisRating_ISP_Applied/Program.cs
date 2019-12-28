﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_ISP_Applied
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine();
            engine.Rate();

            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }
            Console.ReadKey();
        }
    }
}
