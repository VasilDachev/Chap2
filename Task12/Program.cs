using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Фирма, занимаваща се с маркетинг, иска да пази запис с данни на
           нейните служители. Всеки запис трябва да има следната характе-
           ристика – първо име, фамилия, възраст, пол (‘m’ или ‘f’) и уникален
           номер на служителя (27560000 до 27569999). Декларирайте под-
           ходящи променливи, за да се запази информацията за един служител,
           като използвате подходящи типове данни и описателни имена.*/

            string FirstName = Console.ReadLine();
            string Surname = Console.ReadLine();
            string age = Console.ReadLine();
            int nAge = int.Parse(age);
            string mySex = Console.ReadLine();
            char rSex = char.Parse(mySex);
            string number = Console.ReadLine();
            int newNumb = int.Parse(number);
            Console.WriteLine("Name : {0}  Surname : {1}  Age : {2}  Sex : {3}  Unicode : {4}", FirstName, Surname, nAge, rSex, newNumb);
        }
    }
}
