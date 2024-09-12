using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle-Done
             * The vehicle class shall have three string properties Year, Make, and Model-Done
             * Set the defaults to something generic in the Vehicle class-Done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation-Done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-Done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle-Done
             * Add a distict property in the 2 derived classes 
             * such as HasTrunk for Car and HasSideCart for Motorcycle-Done
             * Provide the implementations for the abstract methods-Done
             * Only in the Motorcycle class will you override the virtual drive method-Done
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle 
             * (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class-Done
             * Set the properties with object initializer syntax-Done
             */

            /*
             * Add the 4 vehicles to the list-Done
             * Using a foreach loop iterate over each of the properties-Done
             */

            // Call each of the drive methods for one car and one motorcycle-Done


            var car1 = new Car
            {
                Year = "2024",
                Make = "Toyota",
                Model = "4Runner"
            };
            var motorcycle1 = new Motorcycle
            {
                Year = "2015",
                Make = "Harley-Davidson",
                Model = "Fat Bob"
            };
            Vehicles car2 = new Car 
            {
                Year = "2020",
                Make = "Toyota",
                Model = "4Runner"
            };
            Vehicles motorcycle2 = new Motorcycle 
            {
                Year = "2020",
                Make = "Harley-Davidson",
                Model = "Fat Bob"
            };

            var vehicles = new List<Vehicles> 
            {
               car1, motorcycle1, car2, motorcycle2
            };
            
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This is a {vehicle.Year} {vehicle.Model} {vehicle.Model}.");
            }

            car1.DriveAbstract();
            car1.DriveVirtual();
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();



            #endregion            
            Console.ReadLine();
        }
    }
}
