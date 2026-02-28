using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Sandbox
{
    internal class AttemptsFromLessons
    {
        public static void RightMain()
        {
            double x = 1.0 / 10;
            double sum = 0;
            for (int i = 0; i < 10; i++)
                sum += x;
            Console.WriteLine(Math.Abs(sum - 1) < 1e-9);
            Console.WriteLine(sum == 1);
        }
    }
}
