using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ExercisesOfTheFirstChapter
{
    internal class Exc1
    {
        public static void Exercise1()
        {
            int a = 3;
            int b = 7;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + b;
            b = Math.Abs(b - a);
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
