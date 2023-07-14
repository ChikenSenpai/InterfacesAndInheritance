using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTest
{
    internal class VW : Vehicle, IAutomobile
    {
        private double weight { get; }

        //Constructor:
        public VW(double speed) : base(speed) { }
    }
}
