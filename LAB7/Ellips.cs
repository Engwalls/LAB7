using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    class Ellips : Geometri  // Derives from the class "Geometri"
    {
        double a;           // Field with property
        double b;           // Field with property
        public Ellips()   // Constructor with a default value
        {
            a = 7;
            b = 4;
        }
        public override double Area()   // Method with a return
        {
            return a * b * Math.PI;
        }
    }
}
