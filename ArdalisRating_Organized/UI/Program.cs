using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating_Organized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardalis Insurance Rating System Starting...");
            //var logger = new ConsoleLogger();
            var logger = new FileLogger();
            var engine = new RatingEngine(logger, new FilePolicySource(), new PolicySerializer(), new RaterFactory(logger));
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
