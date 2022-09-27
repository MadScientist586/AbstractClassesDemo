using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public Vehicle()
        {
           
        }

        public string Year { get; set; } = "default";
        public string Make { get; set; } = "default";
        public string Model { get; set; } = "default";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {

        }


    }
}
