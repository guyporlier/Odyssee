using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Ecrit.Output();
        }
    }

    public class Ecrit
    {
        public static void Output()
        {
            String i;

            i = Console.ReadLine();
            if (i == "0")
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("autre");
            }
        }
    }
}

 




