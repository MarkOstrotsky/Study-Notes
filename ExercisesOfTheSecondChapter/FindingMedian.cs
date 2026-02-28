using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ExercisesOfTheSecondChapter
{
    internal class FindingMedian
    {
        public static int FindMedian(int a, int b, int c)
        {
            if (a > b)
                if (b > c) return b;
                else if (a > c) return c;
                else return a;
            else if (a > c) return a;
            else if (b > c) return c;
            else return b;
        }
    }
}
