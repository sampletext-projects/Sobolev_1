using System;

namespace Sobolev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double chisl1 = (2.7 - 0.8) * 7.0 / 3.0;
            double znam1 = (5.2 - 1.4) / (3.0 / 7.0);
            double el1 = chisl1 / znam1;

            double el2 = (7.0 / (30.0 - (93.0 * 18.0 + 5.0) / 18.0) * 9.0 / 4.0) / 0.2;

            double res = el1 - 2.625 + 97.0 / 11.0 - el2 + Math.Pow(Math.PI, 1.0 / 6.0);

            Console.WriteLine(res);
        }
    }
}
