using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicles
    {
        public bool HasTwoTires { get; set; }
        public bool HasNoDoors { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I like to ride!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("I like bikes!");
        }
    }
}
