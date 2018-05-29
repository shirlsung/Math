using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Pick a number to do the following math:");
            int InputOne = Convert.ToInt32(Console.ReadLine());
            int result = subMath.SumofTwo(InputOne);
            int resultOne = subMath.MultbyThree(InputOne);
            int resultTwo = subMath.divbyTen(InputOne);
            Console.WriteLine(result);
            Console.WriteLine(resultOne);
            Console.WriteLine(resultTwo);
            Console.ReadLine();
        }
        
            

        }
}
