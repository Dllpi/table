using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 6; i++)
            {
                Console.WriteLine("" +
                    "");
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write(result + "    ");
                }
            }
            Console.ReadLine();
        }
    }
}