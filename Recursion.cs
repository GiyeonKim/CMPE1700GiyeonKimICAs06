using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Recursion
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(10);

            a.Add(7);
            int e = 0; // sum of the int
            int s = Recursion(a.Count - 1, e, a); // call out the method
            
            Console.WriteLine(s);

            Console.ReadKey();
        }


        static int Recursion(int C, int e, List<int> a) // recursion
        {
            if (C > 0) // if the count is bigger than zero
            {
                e += a[C]; // sum
                return Recursion(C -= 1, e, a);

            }
            return e += a[C];

        }
    }
    }

