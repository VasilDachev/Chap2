using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Декларирайте две променливи от тип int. Задайте им стойности
            съответно 5 и 10. Разменете стойностите им и ги отпечатайте.*/

            int a1 = 5;
            int b1 = 10;
            int aa = b1;
            b1 = a1;
            a1 = aa;

            Console.WriteLine("{0} , {1}", a1, b1);
        }
    }
}
