using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasStorageBasket { get; set; }  
      
        public override void DriveAbstract()
        {
            Console.WriteLine("Two wheels, fast.");
        }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Motorcycle virtual");
        }
    }
}
