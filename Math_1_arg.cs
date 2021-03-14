using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Класс математических формул с 1 агрументом
    /// </summary>
    class Math_1_arg
    {
        /// <summary>
        /// вычисление логорифма по основанию 10
        /// </summary>
        /// <param name="input">входящее значение</param>
        /// <returns></returns>
        public static double math_lg(double input)
        {
            return Math.Log10(input);
        }
        /// <summary>
        /// натуральный логарифм
        /// </summary>
        /// <param name="input">входнон значение</param>
        /// <returns></returns>
        public static double math_log_e(double input)
        {
            return Math.Log(input, Math.E);
        }
        /// <summary>
        /// вычисление тангенса
        /// </summary>
        /// <param name="input">входное значение</param>
        /// <returns></returns>
        public static double math_tan(double input)
        {
            return Math.Tan(input);
        }
        /// <summary>
        /// вычисление котангенса
        /// </summary>
        /// <param name="input">входное значение</param>
        /// <returns></returns>
        public static double math_ctg(double input)
        {
            return 1 / Math.Tan(input);
        }
        /// <summary>
        /// вычисление синуса
        /// </summary>
        /// <param name="input">входное значение</param>
        /// <returns></returns>
        public static double math_sin(double input)
        {
            return Math.Sin(input);
        }
        /// <summary>
        /// вычисление косинуса
        /// </summary>
        /// <param name="input">входное значение</param>
        /// <returns></returns>
        public static double math_cos(double input)
        {
            return Math.Cos(input);
        }
        /// <summary>
        /// корень числа
        /// </summary>
        /// <param name="input">входное число</param>
        /// <returns></returns>
        public static double math_sqrt(double input)
        {
            return Math.Sqrt(input);
        }
        /// <summary>
        /// квадрат числа
        /// </summary>
        /// <param name="input">входное число</param>
        /// <returns></returns>
        public static double math_square(double input)
        {
            return input * input;
        }
        /// <summary>
        /// вычисление факториала
        /// </summary>
        /// <param name="input">входящее значение</param>
        /// <returns></returns>
        public static int math_factorial(int input)
        {
            var result = 1;
            for(int i=1; i<=input; i++)
            {
                result *= i;
            }
            return result;
        }
        /// <summary>
        /// вычисление факториала
        /// </summary>
        /// <param name="input">входящее значение</param>
        /// <returns></returns>
        public static int math_factorial(int input)
        {
            var result = 1;
            for(int i=1; i<=input; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
