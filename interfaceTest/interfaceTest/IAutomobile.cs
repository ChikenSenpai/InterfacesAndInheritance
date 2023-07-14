using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTest
{
    //Interface creates rules for the classes (they need the vatriables and methods in the interface otherwise -> error)
    //An interface helps creating less errors from simply forgetting to give a class a specific variable or method
    interface IAutomobile 
    {
        string licensePlate { get; }
        double speed { get; }
        int wheels { get; }
        void Honk();
        void SpeedUp();
        void SpeedDown();


    }
}
