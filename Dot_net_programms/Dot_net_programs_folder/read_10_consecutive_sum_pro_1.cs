using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int sum = 0,a;
			for (int i = 1; i < 9; i++)
			{
				sum += i;
			}
			Console.WriteLine("Enter you number");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(sum + a);
			Console.ReadLine();
		}
    }
}
