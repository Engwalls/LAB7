using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    class Square : Geometri  // Derives from the class "Geometri"
    {
        double side { get; set; }   // Field with property and Get and Set
        public Square()   // Constructor with a default value
        {
            side = 5;
        }
        public override double Area()   // Method with a return
        {
            return Math.Pow(side, 2);
        }
    }
}
