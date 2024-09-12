using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicles
    {
        public bool HasDoors { get; set; }
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I like to Drive!");
        }

    }
}
