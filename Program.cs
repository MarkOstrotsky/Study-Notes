using System;
using TestProject.ExercisesOfTheSecondChapter;
using TestProject.Sandbox;

namespace TestProject
{
    public enum Color
    {
        Red,
        Green,
        Blue
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetColorNameWrongWay(Color.Blue));   
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
