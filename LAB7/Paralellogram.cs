using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    class Paralellogram : Geometri  //Derives from the class "Geometri"
    {
        double bottom;             // Field with property
        double height;             // Field with property
        public Paralellogram()   // Constructor with a default value
        {
            bottom = 4;
            height = 9;
        }
        public override double Area()   // Method with a return
        {
            return bottom * height;
        }
    }
}
