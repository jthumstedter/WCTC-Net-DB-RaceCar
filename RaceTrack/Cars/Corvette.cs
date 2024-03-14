using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Corvette : RaceCar
    {
        public Corvette()
        {
            Name = "Corvette";
            TopSpeed = 95;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts thundering");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine slowly winds down");
        }
    }
}
