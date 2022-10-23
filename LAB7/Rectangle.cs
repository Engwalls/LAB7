using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
    class Rectangle : Geometri  // Derives from the class "Geometri"
    {
        double width { get; set; }      // Field with property and Get and Set
        double height { get; set; }     // Field with property and Get and Set
        public Rectangle()    // Constructor with a default value
        {
            width = 6.5;
            height = 3.5;
        }
        public override double Area()  // Method with a return
        {
            return width * height;
        }
    }
}
