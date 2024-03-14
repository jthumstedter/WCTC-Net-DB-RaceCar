using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Lightning : Driver
    {
        public Lightning(RaceCar car) : base(car)
        {
            Name = "Lightning";
            SkillLevel = 9;
        }
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
