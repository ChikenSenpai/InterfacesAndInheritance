using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTest
{
    internal class Sedan : Vehicle, IAutomobile
    {
        public new void SpeedUp() //new overrides the 'SpeedUp' Method in the baseclass
        {
            speed += 10;
        }

        //Constructor:
        public Sedan(double speed) : base(speed) { }
    }
}