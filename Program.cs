using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(text);
            int factorial=1;
            for(int i=1; i<=n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of {0} is {1}", n, factorial);
        }
    }
}
