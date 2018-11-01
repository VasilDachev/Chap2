using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Декларирайте две променливи от тип string и им присвоете стойности
            "Hello" и "World". Декларирайте променлива от тип object и ѝ присвоете
            стойността на конкатенацията на двете променливи от тип string (не
            изпускайте интервала по средата). Декларирайте трета променлива от
            тип string и я инициализирайте със стойността на променливата от тип
            object.*/

            string Hello = "Hello";
            string World = "World";
            object myObj = Hello + " " + World;
            Console.WriteLine(myObj);
            

        }
    }
}
