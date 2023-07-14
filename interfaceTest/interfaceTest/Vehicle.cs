using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTest
{
    //Base class:
    internal class Vehicle
    {
        public string licensePlate { get; private set; }
        public double speed { get; protected set; } //protected is like private but gives every subclass access (inheritance)
        public int wheels { get; protected set; }
        
        //Methods:
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        public void SpeedUp()
        {
            speed += 5; 
        }
        public void SpeedDown()
        {
            speed -= 5;
        }

        //Constructor:
        public Vehicle(double speed)
        {
            this.speed = speed;
            this.wheels = 4;
            this.licensePlate = "";
        }
    }
}
