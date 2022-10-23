using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    class Circle : Geometri  // Derives from the class "Geometri"
    {
        double radius { get; set; }  // Field with property and Get and Set

        public Circle()    // Constructor with a default value
        {
            radius = 6.5;
        }
        public override double Area()   // Method with a return
        {
            return radius * radius * Math.PI;
        }
    }
}