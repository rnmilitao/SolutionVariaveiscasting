using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6Variaveis
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Casting implicito
            int i = 10;
            double d = i;

            // Casting explicito
            double d2 = 3.5;
            int i2 = (int)d2;
            Console.WriteLine(i2);
        }
    }
}
