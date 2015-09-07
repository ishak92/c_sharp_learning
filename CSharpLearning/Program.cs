using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning
{
    class Program
    {
        static int square(int n)
        {
            return n * n;
        }

        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i * i);
                i++;
            }
            i = 0;
            while (i < 10)
            {
                Console.WriteLine( square(i) );
                i++;
            }
        }
    }
}
