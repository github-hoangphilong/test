using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(2));
            Console.WriteLine(Cube(2));
            Console.WriteLine(Even(2));
            Console.WriteLine(Odd(2));
            Console.WriteLine(IsPrime(2));
        }
        static int Square(int n)
        {
            int Square = 0;
            Square = n * n;
            return Square;
        }
        static int Cube(int n)
        {
            int Cube = 0;
            Cube = Square(n) * n;
            return Cube;
        }
        static bool IsPrime(int n)
        {
            int count =0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i== 0)
                {
                    count++;
                }
            } if (count == 2)
            {
                return true;
            }
            
            return false;
        }
        static bool Even(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Odd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Ceil(float x)
        {
            int Ceil = (int)x+1;
            if (x<0) 
            {
                Ceil = (int)x;   
            }
            if (x > 0)
            {
                if (x > Ceil)
                {
                    Ceil = Ceil + 1;
                }
            }
            return Ceil;
        }
        //input: 
        public static int Floor(float x)
        {
            int Floor = (int)x-1;
            if (x < 0)
            {
                Floor = (int)x - 1;
            }
            if (x > Floor)
            {
                Floor = Floor + 1;
            }
            return Floor;
        }
    }
}
