using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която сравнява вярно две реални числа с точност до 0.000001.
            double y = 0.1259632;
            double x = 0.1259631;
            double Comp = Math.Sign(x.CompareTo(y));
            Console.WriteLine("If y>x(-1) if y=x(0) if y<x (1) >>> : {0}", Comp);
        }
    }
}
