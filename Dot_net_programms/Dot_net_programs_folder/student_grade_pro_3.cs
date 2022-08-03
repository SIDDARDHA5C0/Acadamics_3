using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_program_1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of subjects");
            int a=Int32.Parse(Console.ReadLine());
            int []a1=new int[a];
            int sum=0;
            Console.WriteLine("Enter your marks");
            for (int i=0; i<a; i++)
            {
                a1[i]=Convert.ToInt32(Console.ReadLine());
                sum += a1[i];
            }
            Console.WriteLine($"{a1} {sum}");
            if (sum > 90)
                Console.WriteLine("grade A");
            else if (sum > 70)
                Console.WriteLine("grade B");
            else if (sum > 50)
                Console.WriteLine("grade C");
            else
                Console.WriteLine("fail");

            Console.ReadLine();
        }
    }
}
