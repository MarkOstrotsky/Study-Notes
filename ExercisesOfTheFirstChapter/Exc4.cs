using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ExercisesOfTheFirstChapter
{
    internal class Exc4
    {
        public void Exercise4()
        {
            int dividend = int.Parse(Console.ReadLine()); //N
            int primeDivisor1 = int.Parse(Console.ReadLine()); //X
            int primeDivisor2 = int.Parse(Console.ReadLine()); //Y
            Console.WriteLine(((dividend - 1)/primeDivisor1) + ((dividend - 1) / primeDivisor2) - ((dividend - 1) / (primeDivisor1 * primeDivisor2)));
        }
    }
}
