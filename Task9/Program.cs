using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Декларирайте две променливи от тип string и им присвоете стойност
            "The "use" of quotations causes difficulties." (без първите и
            последни кавички). В едната променлива използвайте quoted string, а
            в другата не го използвайте.*/

            string U = "The use of quotations causes difficulties.";
            string u = "The \"use \" of quatations causes difficulties";
            Console.Write("{0}  and  {1}", U, u);
        }
    }
}
