using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solvingPS
{
    public class Solve
    {
        public static int Perimeter(int sideA)
        {
            return sideA * 4;
        }

        public static int Area(int sideA)
        {
            return sideA * sideA;
        }

        public static void TermsTens(int number, out int tens, out int terms)
        {
            terms = number % 10;
            tens = number / 10 % 10;
        }
    }
}
