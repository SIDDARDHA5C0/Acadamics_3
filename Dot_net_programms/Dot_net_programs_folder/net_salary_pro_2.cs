using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary");
            int a = int.Parse(Console.ReadLine());
            if (a > 70000)
                Console.WriteLine(a + a * 0.1 + a * 0.2);
            else if (a > 50000)
                    Console.WriteLine(a + a * 0.2 + a * 0.3);
            else
                    Console.WriteLine(a);
                Console.ReadLine();
            
        }
    }
}
