using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// класс математических формул с 2 аргументами
    /// </summary>
    class Math_2_arg
    {
        /// <summary>
        /// логарифм с определенным основанием
        /// </summary>
        /// <param name="input">число под логарифмом</param>
        /// <param name="base_num">основание логарифма</param>
        /// <returns></returns>
        public static double math_log(double input, double base_num)
        {
            return Math.Log(input, base_num);
        }

        /// <summary>
        /// Показательная функция
        /// </summary>
        /// <param name="input">число, которое возводим в степень</param>
        /// <param name="power">степень числа</param>
        /// <returns></returns>
        public static double math_exp_func(double input, double power)
        {
            return Math.Pow(input, power);
        }

        /// <summary>
        /// корень n-ой степени
        /// </summary>
        /// <param name="input">число</param>
        /// <param name="power">степень корня</param>
        /// <returns></returns>
        public static double math_sqrt_n(double input, double power)
        {
            return Math.Pow(input, 1 / power);

        }

        /// <summary>
        /// сумма двух чисел
        /// </summary>
        /// <param name="a1">первое число</param>
        /// <param name="a2">второе число</param>
        /// <returns></returns>
        public static double math_sum(double a1, double a2)
        {
            return a1 + a2;
        }

        /// <summary>
        /// разность двух чисел
        /// </summary>
        /// <param name="minuend">уменьшаемое</param>
        /// <param name="subtrahend">вычитаемое</param>
        /// <returns></returns>
        public static double math_dif(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        /// <summary>
        /// произведение двух чисел
        /// </summary>
        /// <param name="a1">первый множитель</param>
        /// <param name="a2">второй множитель</param>
        /// <returns></returns>
        public static double math_multiply(double a1, double a2)
        {
            return a1 * a2;
        }

        /// <summary>
        /// частное двух чисел
        /// </summary>
        /// <param name="dividend">делимое</param>
        /// <param name="divider">делитель</param>
        /// <returns></returns>
        public static double math_division(double dividend, double divider)
        {
            return dividend / divider;
        }

        /// <summary>
        /// умножение на 10 в степени n
        /// </summary>
        /// <param name="input">входное число</param>
        /// <param name="power">n-ая степень числа 10</param>
        /// <returns></returns>
        public static double math_power_of_ten(double input, double power)
        {
            return input * Math.Pow(10, power);
        }


    }
}
