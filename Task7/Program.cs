﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Декларирайте две променливи от тип string със стойности "Hello" и
            "World". Декларирайте променлива от тип object. Присвоете на тази
            променлива стойността, която се получава от конкатенацията на двете
            стрингови променливи (добавете интервал, ако е необходимо). Отпе-
            чатайте променливата от тип object.*/

            string Hello = "Hello";
            string World = "World";
            object myObj = Hello + " " + World;
            Console.WriteLine(myObj);
        }
    }
}
