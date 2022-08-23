using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    internal class assignmnet2
    {
        static void Main(string[] args)
        {
            Console.Write("Input a first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int minNumber;
            if(m<n)
            {
                minNumber = m;
            }
            else
            {
                minNumber = n;
            }
            Console.WriteLine("minimum number is:" +  minNumber);
            Console.WriteLine();
        }
    }
}
