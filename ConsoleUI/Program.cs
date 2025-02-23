﻿using System;
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
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                Year = "2020",
                Make = "Chevorlet",
                Model = "Trail Boss",
                MaxPeople = 5

            };
            var motorcycle1 = new Motorcycle()
            {

                Year = "2020",
                Make = "Harley Davidson",
                Model = "Street Glide Special",
                HasStorageBasket = false

            };
            Vehicle vehicle1 = new Car()
            {
                Year = "2023",
                Make = "Chevorlet",
                Model = "Tahoe",
                MaxPeople = 8

            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Year = "2019",
                Make = "Yamaha",
                Model = "R15",
                HasStorageBasket = false 

            };
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(vehicle.Year);
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("Trail Boss DriveAbstract:");
            car1.DriveAbstract();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Street Glide Special drive methods:");
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
