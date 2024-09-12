using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicles
    {
        public string Year { get; set; } = "Unknown Year";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Doing Something.");
        }
    }
}
