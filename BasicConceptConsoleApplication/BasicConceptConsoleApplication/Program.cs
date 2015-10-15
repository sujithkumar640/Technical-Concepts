using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptConsoleApplication
{
    class Rectangle
    {
        // member variables
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* my first program in C# */
            Console.WriteLine("Hello World");
            Console.WriteLine("Size of int: {0}", sizeof(int));
            //Console.ReadKey();
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();

            // Type Conversion //
            double d = 5673.74;
            int i;
            // cast double to int.
            i = (int)d;
            Console.WriteLine("Converted double into integer here "+i);

            // Variable Declaration
            short a;
            int b;
            double c;

            /* actual initialization */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("Variable Declaration : a = {0}, b = {1}, c = {2}", a, b, c);

            //Constants Declaration
            const double pi = 3.14159;
            double g;
            Console.WriteLine("Enter Radius: ");
            g = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * g * g;
            Console.WriteLine("Radius: {0}, Area: {1}", g, areaCircle);
            // Loop
            int l;
            for (l=0;l<=4 ; l++)
            {
                Console.WriteLine("Hey! I am Trapped");
            }
            Console.ReadLine(); 
        }
    }
}
