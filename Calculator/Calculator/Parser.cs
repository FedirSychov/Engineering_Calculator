using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// класс преобразования строковой формулы в исполняемую формулу
    /// </summary>
    class Parser
    {
        private string term = "";
        private double nam, arg;
        /// <summary>
        /// конструктор для подсчета формул без переменных
        /// </summary>
        /// <param name="str">формула в виде строки</param>
        public Parser(string str)
        {
            //Обработка входной строки
            foreach (char ch in str)
            {
                if (Char.IsLetterOrDigit(ch) || ch == '^' || ch == '*' || ch == '/' || ch == '+' || ch == '-' || ch == ','
                    || ch == '(' || ch == ')' || ch == '.')
                {

                    term += ch;
                    if (ch == '.') term = term.Substring(0, term.Length - 1) + ',';
                }
            }
            arg = 0.0;
            nam = Product(term);
        }
        /// <summary>
        /// конструктор для подсчета формул с переменной
        /// </summary>
        /// <param name="x">значение переменной</param>
        /// <param name="str">формула в виде строки</param>
        public Parser(double x, string str)
        {
            //Обработка входной строки
            foreach (char ch in str)
            {
                if (Char.IsLetterOrDigit(ch) || ch == '^' || ch == '*' || ch == '/' || ch == '+' || ch == '-' || ch == ','
                    || ch == '(' || ch == ')' || ch == '.')
                {

                    term += ch;
                    if (ch == '.') term = term.Substring(0, term.Length - 1) + ',';
                }
            }
            arg = x;
            nam = Product(term);
        }
        /// <summary>
        /// Метод обработки функций и присваивания значения переменной
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected double Func(string s)
        {
            double element = 0.0;
            string el = "";
            foreach (char ch in s)
            {
                if (!Char.IsLetter(ch)) break;
                el += ch;
            }
            if (el == "sin") element = Math.Sin(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "cos") element = Math.Cos(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "tan") element = Math.Tan(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "asin") element = Math.Asin(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "acos") element = Math.Acos(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "atan") element = Math.Atan(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "exp") element = Math.Exp(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "ln") element = Math.Log(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "abs") element = Math.Abs(Convert.ToDouble(s.Substring(el.Length)));
            if (el == "pi") element = Math.PI;
            if (el != "sin" && el != "cos" && el != "tan" && el != "acos" && el != "asin"
                && el != "atan" && el != "exp" && el != "log" && el != "abs" && el != "pi") element = arg;
            return element;
        }
        /// <summary>
        /// Метод возведения в степень
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected double Power(string s)
        {
            double element;
            string el = "";
            foreach (char ch in s)
            {
                if (ch == '^') break;
                el += ch;
            }
            if (Char.IsLetter(el[0])) element = arg;
            else element = Convert.ToDouble(el);
            if (s.Substring(el.Length + 1) != "")
            {
                element = Math.Pow(element, Element(s.Substring(el.Length + 1)));
            }

            return element;
        }
        /// <summary>
        /// Расчет умножения/деления
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected double Element(string s)
        {
            double element;
            string el = "";
            foreach (char ch in s)
            {
                if (ch == '*' || ch == '/') break;
                el += ch;
            }
            if (Char.IsLetter(el[0]) && el.IndexOf('^') == -1) element = Func(el);
            else
            {
                if (el.IndexOf('^') == -1) element = Convert.ToDouble(el);
                else element = Power(el);
            }
            if (el.Length < s.Length - 1)
            {
                if (s[el.Length] == '*') element *= Element(s.Substring(el.Length + 1));
                if (s[el.Length] == '/') element /= Element(s.Substring(el.Length + 1));
            }
            return element;
        }
        /// <summary>
        /// Входная точка. Выделение элементов
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        protected double Product(string s)
        {
            int co = 0;
            string el = "";
            double element;
            string s1 = s;
            string sstr;
            if (s != "" && (s[0] == '+' || s[0] == '-')) co++;
            for (int i = co; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    el += Breckets(s.Substring(el.Length + co), out sstr);
                    s = el + sstr;
                    co = 0;
                    i = el.Length;
                    if (sstr == "") break;
                }
                if (s[i] == '+' || s[i] == '-') break;
                el += s[i];
            }
            if (s1[0] == '-') element = -Element(el);
            else element = Element(el);
            if (el.Length < s.Length - 1) element += Product(s.Substring(el.Length + co));

            return element;
        }
        /// <summary>
        /// Обработка выражений в скобках
        /// </summary>
        /// <param name="s"></param>
        /// <param name="sstr"></param>
        /// <returns></returns>
        protected string Breckets(string s, out string sstr)
        {
            int co = 1;
            int open = 1;
            int quit = 0;
            string el = "";
            double element;
            while (open != quit)
            {
                if (s[co] == '(')
                {
                    open++;
                }
                if (s[co] == ')') quit++;
                if (open == quit) break;
                el += s[co];
                co++;
            }
            if (co < s.Length - 1) sstr = s.Substring(co + 1);
            else
            {
                sstr = "";
            }
            element = Product(el);

            return element.ToString();
        }
        /// <summary>
        /// результат
        /// </summary>
        public double Nam
        {
            get
            {
                return nam;
            }
        }
    }
}
