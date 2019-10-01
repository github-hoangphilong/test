using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(2));
        }
        static int Square(int n)
        {
            int Square = 0;
            Square = n * n;
            return Square;
        }
    }
}
