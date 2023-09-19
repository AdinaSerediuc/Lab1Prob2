using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex2
Scrieti un program care va calcula media aritmetica a trei numere citite de la
tastatura
            */

            int numar1 = int.Parse(Console.ReadLine());
            int numar2 = int.Parse(Console.ReadLine());
            int numar3 = int.Parse(Console.ReadLine());

            int suma = numar1 + numar2 + numar3;
            int medieAritmetica = suma / 3;

            Console.WriteLine("Media aritmetica a celor 3 numere este =" + medieAritmetica);

        }
    }
}
