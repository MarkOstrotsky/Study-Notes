using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ExercisesOfTheFirstChapter
{
    internal class Exc2
    {
        public static void Exercise2()
        {
            Console.WriteLine("Введите трехзначное число");
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = number % 10;
            int secongDigit = number / 10 % 10;
            int firstDigit = number / 100 % 10;
            int reverceNumber = thirdDigit * 100 + secongDigit * 10 + firstDigit;
            Console.WriteLine(reverceNumber);

        }
    }
}
