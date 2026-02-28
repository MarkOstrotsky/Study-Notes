using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ExercisesOfTheFirstChapter
{
    internal class Exc3
    {
        public void Exercise3(int inputTime)
        {
            //inputTime = int.Parse(Console.ReadLine());
            if (inputTime <= 6) Console.WriteLine(inputTime * 30);
            else if (inputTime <= 12 && inputTime > 6) Console.WriteLine((12 - inputTime) * 30);
            else if (inputTime <= 18 && inputTime > 12) Console.WriteLine((inputTime - 12) * 30);
            else if (inputTime <= 24 && inputTime > 18) Console.WriteLine((24 - inputTime) * 30);
        }
    }
}
