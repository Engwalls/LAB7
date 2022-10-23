using System;

namespace LAB7
{
    class Program                                           // Erik Engvall      NET22
    {
        static void Main(string[] args)
        { //---------------------------------------------- New objects and writing out the area information on the called method

            Circle circle = new Circle();                                                     // Object
            Console.WriteLine("The area of the circle is: " + circle.Area());                 // Calling the method
            Console.WriteLine("");

            Rectangle rectangle = new Rectangle();                                            // Object
            Console.WriteLine("The area of the rectangle is: " + rectangle.Area());           // Calling the method
            Console.WriteLine("");

            Square square = new Square();                                                     // Object
            Console.WriteLine("The area of the square is: " + square.Area());                 // Calling the method
            Console.WriteLine("");

            Ellips ellips = new Ellips();                                                     // Object 
            Console.WriteLine("The area of the ellips is: " + ellips.Area());                 // Calling the method
            Console.WriteLine("");

            Paralellogram paralellogram = new Paralellogram();                                // Object
            Console.WriteLine("The area of the paralellogram is: " + paralellogram.Area());   // Calling the method
        }
    }
}
