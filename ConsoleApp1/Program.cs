using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a második számot:");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("A számok összege: {0}",c);
            Console.ReadKey();
        }
    }
}
