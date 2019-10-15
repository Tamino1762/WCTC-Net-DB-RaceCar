using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    class Potter : Driver
    {
        public Potter(RaceCar car) : base(car)
        {
            Name = "Potter";
            SkillLevel = 20;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
