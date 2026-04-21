using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ExercisesOfTheSecondChapter
{
    internal class ConditionalOperators
    {
        /// <summary>
        /// Функция,созданная в качестве практики использования тернарного опертора.
        /// Выводит текстом рекомендацию надеть худи или нет в зависимости от температуры за окном
        /// </summary>
        /// <param name="temperatureOutside"></param>
        public static void DetermineWeather(int temperatureOutside)
        {
            Console.WriteLine($"Temperature is {temperatureOutside}\n" + (temperatureOutside >= 20 ? "The weather is simply wonderful!" : "Better wear a hoodie..."));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operationId">Название операции на английском</param>
        /// <param name="firstValue">Значние первого операнда, в отношении которого будет производится операция</param>
        /// <param name="secondValue">Значение второго операнда</param>
        /// <returns>Возвращает результат операции, которую определяет пользователь на английском. Операция производится над первым значением.</returns>
        public static string ReturnResultArithmeticPperations(string operationId, int firstValue, int secondValue)
        {
            switch (operationId)
            {
                case "Addition": return $"{firstValue + secondValue}";
                case "Difference": return $"{firstValue - secondValue}";
                case "Division": return $"{ firstValue / secondValue}";
                case "Multiplication": return $"{firstValue * secondValue}";
                default: return "Unknown operation";
            }
        }
    }
}
