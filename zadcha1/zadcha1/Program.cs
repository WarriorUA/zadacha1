using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadcha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0) Console.WriteLine("Dodatne");
            else if (n < 0) Console.WriteLine("Widemne");
            else Console.WriteLine("NULL");
            Console.ReadKey();
        }
    }
}
