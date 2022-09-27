using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public int MaxPeople { get; set; } = 0;  
       
        public override void DriveAbstract()
        {
            Console.WriteLine("4 wheels, safe to drive.");
        }
       
    }
}
