using System;
using modificadores;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {

            int x = 10;
            Console.WriteLine("-----------------REF-----------------");


            calculadora.Triple(ref x);
            Console.WriteLine(x);

            Console.WriteLine("-----------------OUT-----------------");

            int y = 10;
            int quad;
            calculadora.Double(y, out quad);
            Console.WriteLine(quad);
        }
    }
}