using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// класс математических функций с 3 аргументами
    /// </summary>
    class Math_3_arg
    {
        /// <summary>
        /// вычисление определенного интеграла
        /// </summary>
        /// <param name="formula">подинтегральное выражение в виде строки</param>
        /// <param name="a">левый предел</param>
        /// <param name="b">правый предел</param>
        /// <returns></returns>
        public static double math_integral(string formula, double a, double b)
        {
            //точность
            int accuracy = 1000000;
            //шаг
            double step = 1.0 / accuracy;
            //количество циклов
            int n = (int)((b - a) * accuracy);
            //интеграл считается примерно как произведение первого множителя на ряд
            double first_mult = (b - a) / n;
            double second_mult = 0;
            //цикл подсчета ряда
            for (double i = a; i < b; i += step)
            {
                //считаем формулу с подставленным значением из отрезка
                Parser parse1 = new Parser(i, formula);
                //прибавляем для подсчета ряда
                second_mult += parse1.Nam;
            }
            //подсчет результата
            double rez = first_mult * second_mult;
            //если результат очень приближен к целому числу или десятой части числа, происходит округление
            if (Math.Abs(rez - Math.Round(rez)) <= step) return Math.Round(rez);
            else if (Math.Abs(rez - Math.Round(rez, 1)) <= step) return Math.Round(rez, 1);
            else return Math.Round(rez, 6);
        }
    }
}
