using System;
using TestProject.ExercisesOfTheSecondChapter;
using TestProject.ExercisesOfTheFirstChapter;
using TestProject.Sandbox;

namespace TestProject
{
    //public enum Color
    //{
    //    Red,
    //    Green,
    //    Blue
    //}

    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetColorNameWrongWay(Color.Blue));
            Console.WriteLine(ConditionalOperators.ReturnResultArithmeticPperations("Addition", 2, 2));
            ConditionalOperators.DetermineWeather(19);
        }

        static string GetColorNameWrongWay(Color color)
        {
            if (color == Color.Red) return "Красный";
            if (color == Color.Green) return "Зеленый";
            if (color == Color.Blue) return "Синий";

            return "";
        }
    }
}
