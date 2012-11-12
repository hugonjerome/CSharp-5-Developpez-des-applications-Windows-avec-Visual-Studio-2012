using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector A = new Vector(1, 2);
            Vector B = new Vector(2, 4);
            Vector C = A.Addition(B);
            Console.WriteLine("C : {0}", C);

            Vector D = A + B + C;
            Console.WriteLine("D : {0}", D);

            Vector E = A + 10;
            Console.WriteLine("E : {0}", E);

            A += 10;
            Console.WriteLine("A : {0}", A);

            Console.WriteLine("A == E : {0}", A == E);
            Console.WriteLine("A != E : {0}", A != E);
            Console.WriteLine("A.Equals(E) : {0}", A.Equals(E));
            Console.WriteLine("A.Equals(new object()) : {0}", A.Equals(new object()));

            Console.ReadLine();
        }
    }
}
