using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Calculator : Form
    {
        int MainNumberOfLine=1;
        string[] MainScreenMas = new string[] { "", "", "", "", "________________________________________", ""};
        string Memory="";
        bool formula_mode = false;
        bool conversion_mode = false;

        List <Operation> OperationHistory = new List<Operation>();
        int CurrentOperationOnScreen = 0;
        
        public Calculator()
        {
            InitializeComponent();
            Calculate(false);
            OperationHistory.Add(new Operation(new string[] { "", "", "", "", "________________________________________", "" }, false));
            CurrentOperationOnScreen++; 
        }

        private void button_pi_Click(object sender, EventArgs e)
        {
            MainScreenMas[MainNumberOfLine] += "3,14159";
            Calculate(false);
        }

        private void button_number_9_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "9";
            }
            else Conversion_textBox1.Text += "9";

            Calculate(false);
        }

        private void button_number_8_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "8";
            }
            else Conversion_textBox1.Text += "8";

            Calculate(false);
        }

        private void button_number_7_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "7";
            }
            else Conversion_textBox1.Text += "7";

            Calculate(false);
        }

        private void button_number_6_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "6";
            }
            else Conversion_textBox1.Text += "6";

            Calculate(false);
        }

        private void button_number_5_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "5";
            }
            else Conversion_textBox1.Text += "5";

            Calculate(false);
        }

        private void button_number_4_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "4";
            }
            else Conversion_textBox1.Text += "4";

            Calculate(false);
        }

        private void button_number_3_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "3";
            }
            else Conversion_textBox1.Text += "3";

            Calculate(false);
        }

        private void button_number_2_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "2";
            }
            else Conversion_textBox1.Text += "2";

            Calculate(false);
        }

        private void button_number_1_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "1";
            }
            else Conversion_textBox1.Text += "1";

            Calculate(false);
        }

        private void button_number_0_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += "0";
            }
            else Conversion_textBox1.Text += "0";

            Calculate(false);
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                MainScreenMas[MainNumberOfLine] += ",";
            }
            else Conversion_textBox1.Text += ",";

            Calculate(false);
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            if (MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "x";
            }

            Calculate(false);
        }

        private void button_absx_Click(object sender, EventArgs e) // inizio 
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "abs(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "abs(";
            }

            Calculate(false);
        }

        private void button_acosx_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "acos(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "acos(";
            }

            Calculate(false);
        }

        private void button_atanx_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "atan(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "atan(";
            }

            Calculate(false);
        }

        private void button_asinx_Click(object sender, EventArgs e)// fine 
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "asin(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "asin(";
            }

            Calculate(false);
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "x^2";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "^2";
            }

            Calculate(false);
        }

        private void button_tanx_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "tan(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "tan(";
            }

            Calculate(false);
        }

        private void button_cotx_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "cot(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "cot(";
            }

            Calculate(false);
        }

        private void button_cosx_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "cos(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "cos(";
            }

            Calculate(false);
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "x^(1/2)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "^(1/2)";
            }

            Calculate(false);
        }

        private void button_sinx_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "sin(x)";
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "sin(";
            }

            Calculate(false);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "+";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "+";
            }

            Calculate(false);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "-";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "-";
            }

            Calculate(false);
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "*";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "*";
            }

            Calculate(false);
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "/";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "/";
            }

            Calculate(false);
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "x^n";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "^";
            }

            Calculate(false);
        }

        private void button_power_of_ten_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "x*10^n";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "*10^(";
            }

            Calculate(false);
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            if (!formula_mode && MainScreenMas[0] == "")
            {
                MainScreenMas[0] += "x^(1/n)";
                if (MainScreenMas[1] != "")
                {
                    MainNumberOfLine++;
                }
            }

            if (formula_mode && MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "^(1/";
            }

            Calculate(false);
        }

        private void button_definite_integral_Click(object sender, EventArgs e)
        {
            if (MainScreenMas[0] == "")
            {
                formula_mode_change(true);
                MainScreenMas[0] += "a˅∫^b(x)";
            }
            Calculate(false);
        }

        private void Calculate(bool button_count_Click)
        {
            int NumberOfArguments = 0;
            int NumberForTranslation;
            string Result;

            if (!conversion_mode)
            {
                if (!formula_mode)
                {
                    if (MainScreenMas[1] != "" && MainScreenMas[1] != "-")
                    {
                        if (MainScreenMas[0] == "tan(x)") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math_1_arg.math_tan(Convert.ToDouble(MainScreenMas[1]))); }
                        if (MainScreenMas[0] == "cot(x)") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math_1_arg.math_ctg(Convert.ToDouble(MainScreenMas[1]))); }
                        if (MainScreenMas[0] == "sin(x)") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math_1_arg.math_sin(Convert.ToDouble(MainScreenMas[1]))); }
                        if (MainScreenMas[0] == "cos(x)") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math_1_arg.math_cos(Convert.ToDouble(MainScreenMas[1]))); }
                        if (MainScreenMas[0] == "x^(1/2)") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math_1_arg.math_sqrt(Convert.ToDouble(MainScreenMas[1]))); }
                        if (MainScreenMas[0] == "x^2") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math_1_arg.math_square(Convert.ToDouble(MainScreenMas[1]))); }
                        if (MainScreenMas[0] == "abs(x)") { NumberOfArguments = 1; MainScreenMas[5] = Convert.ToString(Math.Abs(Convert.ToDouble(MainScreenMas[1]))); }

                        if (MainScreenMas[0] == "acos(x)")
                        {
                            NumberOfArguments = 1;
                            Parser Calculations = new Parser(String.Format("acos({0})", MainScreenMas[1]));
                            MainScreenMas[5] = Convert.ToString(Calculations.Nam);
                        }
                        if (MainScreenMas[0] == "atan(x)")
                        {
                            NumberOfArguments = 1;
                            Parser Calculations = new Parser(String.Format("atan({0})", MainScreenMas[1]));
                            MainScreenMas[5] = Convert.ToString(Calculations.Nam);
                        }
                        if (MainScreenMas[0] == "asin(x)")
                        {
                            NumberOfArguments = 1;
                            Parser Calculations = new Parser(String.Format("asin({0})", MainScreenMas[1]));
                            MainScreenMas[5] = Convert.ToString(Calculations.Nam);
                        }
                    }

                    if (MainScreenMas[1] != "" && MainScreenMas[1] != "-" && MainScreenMas[2] != "" && MainScreenMas[2] != "-")
                    {
                        if (MainScreenMas[0] == "+") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_sum(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                        if (MainScreenMas[0] == "-") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_dif(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                        if (MainScreenMas[0] == "*") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_multiply(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                        if (MainScreenMas[0] == "/") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_division(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                        if (MainScreenMas[0] == "x^n") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_exp_func(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                        if (MainScreenMas[0] == "x*10^n") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_power_of_ten(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                        if (MainScreenMas[0] == "x^(1/n)") { NumberOfArguments = 2; MainScreenMas[5] = Convert.ToString(Math_2_arg.math_sqrt_n(Convert.ToDouble(MainScreenMas[1]), Convert.ToDouble(MainScreenMas[2]))); }
                    }

                    if (MainScreenMas[MainNumberOfLine] != "" && MainScreenMas[MainNumberOfLine].Substring(0, 1) != "-")
                    {
                        NumberForTranslation = Convert.ToInt32(Math.Round(Convert.ToDouble(MainScreenMas[MainNumberOfLine]), 0));
                        Result = NumberForTranslation + " — " + Convert.ToString(NumberForTranslation, 2) + "(2)" + Environment.NewLine + NumberForTranslation + " — "
                            + Convert.ToString(NumberForTranslation, 8) + "(8)" + Environment.NewLine + NumberForTranslation + " — " + Convert.ToString(NumberForTranslation, 16) + "(16)";
                        TranslationScreen.Text = Result;
                    }
                    else TranslationScreen.Text = "";

                }
                else
                {
                    if (button_count_Click)
                    {
                        if (MainScreenMas[0] == "" && MainScreenMas[1] != "" && MainScreenMas[1] != "-")
                        {
                            Parser Calculations = new Parser(MainScreenMas[1]);
                            MainScreenMas[5] = Convert.ToString(Calculations.Nam);
                        }

                        if (MainScreenMas[1] != "" && MainScreenMas[1] != "-" && MainScreenMas[2] != "" && MainScreenMas[2] != "-" && MainScreenMas[3] != "" && MainScreenMas[3] != "-")
                        {
                            if (MainScreenMas[0] == "a˅∫^b(x)") { MainScreenMas[5] = Convert.ToString(Math_3_arg.math_integral(MainScreenMas[1], Convert.ToDouble(MainScreenMas[2]), Convert.ToDouble(MainScreenMas[3]))); }
                        }
                    }

                    
                    if (MainScreenMas[5] != "не число" && MainScreenMas[5] != "" && MainScreenMas[5].Substring(0, 1) != "-")
                    {
                        NumberForTranslation = Convert.ToInt32(Math.Round(Convert.ToDouble(MainScreenMas[5]), 0));
                        Result = NumberForTranslation + " — " + Convert.ToString(NumberForTranslation, 2) + "(2)" + Environment.NewLine + NumberForTranslation + " — "
                            + Convert.ToString(NumberForTranslation, 8) + "(8)" + Environment.NewLine + NumberForTranslation + " — " + Convert.ToString(NumberForTranslation, 16) + "(16)";
                        TranslationScreen.Text = Result;
                    }
                    else TranslationScreen.Text = "";
                    
                    
                }

                if (NumberOfArguments == 1 && (MainScreenMas[1] == "" || MainScreenMas[1] == "-")) MainScreenMas[5] = "";
                if (NumberOfArguments == 2 && (MainScreenMas[1] == "" || MainScreenMas[1] == "-" || MainScreenMas[2] == "" || MainScreenMas[2] == "-")) MainScreenMas[5] = "";
                if (NumberOfArguments == 3 && (MainScreenMas[1] == "" || MainScreenMas[1] == "-" || MainScreenMas[2] == "" || MainScreenMas[2] == "-" || MainScreenMas[3] == "" || MainScreenMas[3] == "-")) MainScreenMas[5] = "";

                Show_Screen(MainScreenMas, MainScreen, formula_mode);
            }
            else
            {
                if (Conversion_textBox1.Text != "")
                {
                    if (banner.Text == "Длина")
                    {
                        double[,] LengthMas = {
                        {1, 0.001, 0.000001, 0.0000001, 0.000000001, 0.000000000001, 0.000000039370079, 0.00000000328084, 0.000000001093613, 0.000000000000621, 0.00000000000054 },
                        {1000, 1, 0.001, 0.0001, 0.000001, 0.000000001, 0.000039, 0.000003, 0.000001, 0.000000000621371, 0.000000000539957 },
                        {1000000, 1000, 1, 0.1, 0.001, 0.000001, 0.03937, 0.003281, 0.001094, 0.000000621371192, 0.000000539956803 },
                        {10000000, 10000, 10, 1, 0.01, 0.00001, 0.393701, 0.032808, 0.010936, 0.000006, 0.000005 },
                        {1000000000, 1000000, 1000, 100, 1, 0.001, 39.37008, 3.28084, 1.093613, 0.000621, 0.00054 },
                        {1000000000000, 1000000000, 1000000, 100000, 1000, 1, 39370.08, 3280.84, 1093.613, 0.621371, 0.539957},
                        {25400000, 25400, 25.4, 2.54, 0.0254, 0.000025, 1, 0.083333, 0.027778, 0.000016, 0.000014 },
                        {304800000, 304800, 304.8, 30.48, 0.3048, 0.000305, 12, 1, 0.333333, 0.000189, 0.000165 },
                        {914400000, 914400, 914.4, 91.44, 0.9144, 0.000914, 36, 3, 1, 0.000568, 0.000494 },
                        {1609344000000, 1609344000, 1609344, 160934.4, 1609.344, 1.609344, 63360, 5280, 1760, 1, 0.868976},
                        {1852000000000, 1852000000, 1852000, 185200, 1852, 1.852, 72913.39, 6076.115, 2025.372, 1.150779, 1}
                        };
                        if (Conversion_comboBox1.Text != "" && Conversion_comboBox2.Text != "") Conversion_textBox2.Text = Convert.ToString(Convert.ToDouble(Conversion_textBox1.Text) * LengthMas[Conversion_comboBox1.SelectedIndex, Conversion_comboBox2.SelectedIndex]);
                    }  

                    if (banner.Text == "Вес")
                    {
                        double[,] WeightMas = {
                        {1, 200, 20, 2, 0.2, 0.02, 0.002, 0.0002, 0.0000002},
                        {0.005, 1, 0.1, 0.01, 0.001, 0.0001, 0.00001, 0.000001, 0.000000001 },
                        {0.05, 10, 1, 0.1, 0.01, 0.001, 0.0001, 0.00001, 0.00000001 },
                        {0.5, 100, 10, 1, 0.1, 0.01, 0.001, 0.0001, 0.0000001 },
                        {5, 1000, 100, 10, 1, 0.1, 0.01, 0.001, 0.000001 },
                        {50, 10000, 1000, 100, 10, 1, 0.1, 0.01, 0.00001 },
                        {500, 100000, 10000, 1000, 100, 10, 1, 0.1, 0.0001 },
                        {5000, 1000000, 100000, 10000, 1000, 100, 10, 1, 0.001 },
                        {5000000, 1000000000, 100000000, 10000000, 1000000, 100000, 10000, 1000, 1 }
                        };
                        if (Conversion_comboBox1.Text != "" && Conversion_comboBox2.Text != "") Conversion_textBox2.Text = Convert.ToString(Convert.ToDouble(Conversion_textBox1.Text) * WeightMas[Conversion_comboBox1.SelectedIndex, Conversion_comboBox2.SelectedIndex]);
                    }

                    if (banner.Text == "Скорость")
                    {
                        double[,] SpeedMas = {
                        {1, 0.01, 0.036, 0.032808, 0.022371, 0.01944 },
                        {100, 1, 3.6, 3.28084, 2.237136, 1.944012 },
                        {27.77778, 0.277778, 1, 0.911344, 0.621427, 0.540003 },
                        {30.48, 0.3048, 1.09728, 1, 0.681879, 0.592535 },
                        {44.7, 0.447, 1.6092, 1.466535, 1, 0.868974 },
                        {51.44, 0.5144, 1.85184, 1.687664, 1.150783, 1 }
                        };
                        if (Conversion_comboBox1.Text != "" && Conversion_comboBox2.Text != "") Conversion_textBox2.Text = Convert.ToString(Convert.ToDouble(Conversion_textBox1.Text) * SpeedMas[Conversion_comboBox1.SelectedIndex, Conversion_comboBox2.SelectedIndex]);
                    }

                    if (banner.Text == "Время")
                    {
                        double[,] TimeMas = {
                        {1, 0.001, 0.000001, 0.000000016666667, 0.000000000277778, 0.000000000011574, 0.000000000001653, 0.000000000000032 },
                        {1000, 1, 0.001, 0.000017, 0.000000277777778, 0.000000011574074, 0.000000001653439, 0.000000000031688 },
                        {1000000, 1000, 1, 0.016667, 0.000278, 0.000012, 0.000002, 0.000000031688088 },
                        {60000000, 60000, 60, 1, 0.016667, 0.000694, 0.000099, 0.000002 },
                        {3600000000, 3600000, 3600, 60, 1, 0.041667, 0.005952, 0.000114 },
                        {86400000000, 86400000, 86400, 1440, 24, 1, 0.142857, 0.002738 },
                        {604800000000, 604800000, 604800, 10080, 168, 7, 1, 0.019165 },
                        {31557600000000, 31557600000, 31557600, 525960, 8766, 365.25, 52.17857, 1 }
                        };
                        if (Conversion_comboBox1.Text != "" && Conversion_comboBox2.Text != "") Conversion_textBox2.Text = Convert.ToString(Convert.ToDouble(Conversion_textBox1.Text) * TimeMas[Conversion_comboBox1.SelectedIndex, Conversion_comboBox2.SelectedIndex]);
                    }

                    if (banner.Text == "Данные")
                    {
                        double[,] DataMas = {
                        {1, 0.125, 0.001, 0.000977, 0.000125, 0.000122, 0.000001, 0.000000953674316, 0.000000125, 0.00000011920929, 0.000000001, 0.000000000931323, 0.000000000125, 0.000000000116415 },
                        {8, 1, 0.008, 0.007812, 0.001, 0.000977, 0.000008, 0.000008, 0.000001, 0.000000953674316, 0.000000008, 0.000000007450581, 0.000000001, 0.000000000931323 },
                        {1000, 125, 1, 0.976563, 0.125, 0.12207, 0.001, 0.000954, 0.000125, 0.000119, 0.000001, 0.000000931322575, 0.000000125, 0.000000116415322 },
                        {1024, 128, 1.024, 1, 0.128, 0.125, 0.001024, 0.000977, 0.000128, 0.000122, 0.000001, 0.000000953674316, 0.000000128, 0.00000011920929 },
                        {8000, 1000, 8, 7.8125, 1, 0.976563, 0.008, 0.007629, 0.001, 0.000954, 0.000008, 0.000007, 0.000001, 0.000000931322575 },
                        {8192, 1024, 8.192, 8, 1.024, 1, 0.008192, 0.007812, 0.001024, 0.000977, 0.000008, 0.000008, 0.000001, 0.000000953674316 },
                        {1000000, 125000, 1000, 976.5625, 125, 122.0703, 1, 0.953674, 0.125, 0.119209, 0.001, 0.000931, 0.000125, 0.000116 },
                        {1048576, 131072, 1048.576, 1024, 131.072, 128, 1.048576, 1, 0.131072, 0.125, 0.001049, 0.000977, 0.000131, 0.000122},
                        {8000000, 1000000, 8000, 7812.5, 1000, 976.5625, 8, 7.629395, 1, 0.953674, 0.008, 0.007451, 0.001, 0.000931 },
                        {8388608, 1048576, 8388.608, 8192, 1048.576, 1024, 8.388608, 8, 1.048576, 1, 0.008389, 0.007812, 0.001049, 0.000977 },
                        {1000000000, 125000000, 1000000, 976562.5, 125000, 122070.3, 1000, 953.6743, 125, 119.2093, 1, 0.931323, 0.125, 0.116415 },
                        {1073741824, 134217728, 1073742, 1048576, 134217.7, 131072, 1073.742, 1024, 134.2177, 128, 1.073742, 1, 0.134218, 0.125 },
                        {8000000000, 1000000000, 8000000, 7812500, 1000000, 976562.5, 8000, 7629.395, 1000, 953.6743, 8, 7.450581, 1, 0.931323 },
                        {8589934592, 1073741824, 8589935, 8388608, 1073742, 1048576, 8589.935, 8192, 1073.742, 1024, 8.589935, 8, 1.073742, 1 }
                        };
                        if (Conversion_comboBox1.Text != "" && Conversion_comboBox2.Text != "") Conversion_textBox2.Text = Convert.ToString(Convert.ToDouble(Conversion_textBox1.Text) * DataMas[Conversion_comboBox1.SelectedIndex, Conversion_comboBox2.SelectedIndex]);
                    }
                }
                else Conversion_textBox2.Text = "";
            }
        }

        private void Show_Screen(string[] ScreenMas, TextBox Screen, bool mode)
        {
            formula_mode_change(mode);

            string[] Addition = new string[] { "      ", "      ", "      ", "      ", "", "      " };
                
            if (MainScreenMas[0] == "tan(x)" || MainScreenMas[0] == "cot(x)"|| MainScreenMas[0] == "sin(x)" || MainScreenMas[0] == "cos(x)" || MainScreenMas[0] == "x^(1/2)" 
                || MainScreenMas[0] == "x^2" || MainScreenMas[0] == "abs(x)" || MainScreenMas[0] == "acos(x)" || MainScreenMas[0] == "atan(x)" || MainScreenMas[0] == "asin(x)") 
            {
                Addition[0] = " (fun)";
                Addition[1] = " (x)  ";
                Addition[5] = " (res)";
            }
            if (MainScreenMas[0] == "+" || MainScreenMas[0] == "-" || MainScreenMas[0] == "*" || MainScreenMas[0] == "/")
            {
                Addition[0] = " (fun)";
                Addition[1] = " (x1) ";
                Addition[2] = " (x2) ";
                Addition[5] = " (res)";
            }
            if (MainScreenMas[0] == "x^n" || MainScreenMas[0] == "x*10^n" || MainScreenMas[0] == "x^(1/n)")
            {
                Addition[0] = " (fun)";
                Addition[1] = " (x)  ";
                Addition[2] = " (n)  ";
                Addition[5] = " (res)";
            }
            if (MainScreenMas[0] == "a˅∫^b(x)")
            {
                Addition[0] = " (fun)";
                Addition[1] = " (f)  ";
                Addition[2] = " (a)  ";
                Addition[3] = " (b)  ";
            }

            Screen.Text = "";

            for (int i=0; i<ScreenMas.Length; i++)
            {
                Screen.Text += ScreenMas[i] + Addition[i]+ Environment.NewLine;
            }
        }

        private void button_next_line_Click(object sender, EventArgs e)
        {
            if (MainScreenMas[0] != "") 
            {
                if (!formula_mode)
                {
                    if (MainScreenMas[0] == "+" || MainScreenMas[0] == "-" || MainScreenMas[0] == "*" || MainScreenMas[0] == "/" || MainScreenMas[0] == "x^n" || MainScreenMas[0] == "x*10^n" || MainScreenMas[0] == "x^(1/n)")
                    {
                        if (MainNumberOfLine < 2 && MainScreenMas[MainNumberOfLine] != "" && MainScreenMas[MainNumberOfLine] != "-") MainNumberOfLine++;
                    }
                }

                if (formula_mode)
                {
                    if (MainScreenMas[0] == "a˅∫^b(x)")
                    {
                        if (MainNumberOfLine < 3 && MainScreenMas[MainNumberOfLine] != "" && MainScreenMas[MainNumberOfLine] != "-") MainNumberOfLine++;
                    }
                }
            }

            Calculate(false);
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                var NewMainScreenMas = new string[] { "", "", "", "", "________________________________________", "" };
                MainScreenMas = NewMainScreenMas;
                MainNumberOfLine = 1;
                MainScreen.Text = "";
            }
            else
            {
                Conversion_textBox1.Text = "";
                Conversion_textBox2.Text = "";
            }

            Calculate(false);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (!conversion_mode)
            {
                if (MainScreenMas[MainNumberOfLine] != "")
                {
                    if (MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "(")
                    {
                        MainScreenMas[MainNumberOfLine] = MainScreenMas[MainNumberOfLine].Substring(0, MainScreenMas[MainNumberOfLine].Length - 1);

                        while (MainScreenMas[MainNumberOfLine].Length != 0 &&
                            (
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "c" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "o" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "t" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "s" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "a" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "n" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "i" ||
                            MainScreenMas[MainNumberOfLine].Substring(MainScreenMas[MainNumberOfLine].Length - 1, 1) == "b"
                            )
                            )
                        {
                            MainScreenMas[MainNumberOfLine] = MainScreenMas[MainNumberOfLine].Substring(0, MainScreenMas[MainNumberOfLine].Length - 1);
                        }
                    }
                    else MainScreenMas[MainNumberOfLine] = MainScreenMas[MainNumberOfLine].Substring(0, MainScreenMas[MainNumberOfLine].Length - 1);
                }
            }
            else
            {
                if (Conversion_textBox1.Text.Length!=0) Conversion_textBox1.Text = Conversion_textBox1.Text.Substring(0, Conversion_textBox1.Text.Length - 1);
            }

            Calculate(false);
        }

        private void button_plus_minus_Click(object sender, EventArgs e)
        {
            if (MainScreenMas[MainNumberOfLine] != "")
            {
                if (MainScreenMas[MainNumberOfLine].Substring(0, 1) != "-") MainScreenMas[MainNumberOfLine] = MainScreenMas[MainNumberOfLine].Insert(0, "-");
                else MainScreenMas[MainNumberOfLine] = MainScreenMas[MainNumberOfLine].Substring(1, MainScreenMas[MainNumberOfLine].Length - 1);
            }
            else MainScreenMas[MainNumberOfLine] += "-";

            Calculate(false);
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            Calculate(true);
            var NewMainScreenMas = new string[] { "", "", "", "", "________________________________________", "" };
            if (MainScreenMas[5] != "не число")
            {
                NewMainScreenMas[1] = MainScreenMas[5];

                OperationHistory.Add(new Operation(MainScreenMas, formula_mode));
                CurrentOperationOnScreen = OperationHistory.Count() - 1;

                MainScreenMas = NewMainScreenMas;
                MainNumberOfLine = 1;
                MainScreen.Text = "";

                if (!formula_mode) Calculate(false);
                else Show_Screen(MainScreenMas, MainScreen, formula_mode);
            }
            else
            {
                MainScreenMas = NewMainScreenMas;
                MainNumberOfLine = 1;
                MainScreen.Text = "";

                Show_Screen(new string[] { "", "не число", "", "", "________________________________________", "" }, MainScreen, formula_mode);
            }
        }

        private void button_memory_add_Click(object sender, EventArgs e)
        {   
            if (MainScreenMas[MainNumberOfLine] != "" && MainScreenMas[MainNumberOfLine] != "-") Memory = MainScreenMas[MainNumberOfLine];
        }

        private void button_memory_read_Click(object sender, EventArgs e)
        {
            MainScreenMas[MainNumberOfLine] += Memory;
            Calculate(false);
        }

        private void button_memory_clear_Click(object sender, EventArgs e)
        {
            Memory = "";
        }

        private void button_formula_mode_Click(object sender, EventArgs e)
        {
            formula_mode_change(!formula_mode);
        }

        private void button_bracket_left_Click(object sender, EventArgs e)
        {
            if (MainNumberOfLine == 1)
            {
                MainScreenMas[1] += "(";
            }

            Calculate(false);
        }

        private void button_bracket_right_Click(object sender, EventArgs e)
        {
            if (MainNumberOfLine == 1)
            {
                MainScreenMas[1] += ")";
            }

            Calculate(false);
        }

        private void formula_mode_change(bool formula_mode_var)
        {
            if (formula_mode != formula_mode_var)
            {
                var NewMainScreenMas = new string[] { "", "", "", "", "________________________________________", "" };
                MainScreenMas = NewMainScreenMas;
                MainNumberOfLine = 1;
                MainScreen.Text = "";
                Calculate(false);
            }

            if (formula_mode_var)
            {
                button_bracket_right.Visible = true;
                button_bracket_left.Visible = true;
                button_x.Visible = true;
                button_plus_minus.Visible = false;
                button_formula_mode.BackColor = Color.LightGreen;
                formula_mode = formula_mode_var;
            }
            else
            {
                button_bracket_right.Visible = false;
                button_bracket_left.Visible = false;
                button_x.Visible = false;
                button_plus_minus.Visible = true;
                button_formula_mode.BackColor = Color.Salmon;
                formula_mode = formula_mode_var;
            }

        }

        private void PreviousOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_CE_Click(sender, e);

            if (CurrentOperationOnScreen != -1 && OperationHistory.Count>1)
            {
                MainScreenMas = OperationHistory[CurrentOperationOnScreen].Screen;
                formula_mode = OperationHistory[CurrentOperationOnScreen].Mode;
                MainNumberOfLine = 1;
                Show_Screen(MainScreenMas, MainScreen, formula_mode);
                CurrentOperationOnScreen--;
            }
        }

        private void NextOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_CE_Click(sender, e);

            if (OperationHistory.Count > 1)
            {

                if (CurrentOperationOnScreen + 2 <= OperationHistory.Count - 1)
                {
                    MainScreenMas = OperationHistory[CurrentOperationOnScreen +2].Screen;
                    formula_mode = OperationHistory[CurrentOperationOnScreen +2].Mode;
                    MainNumberOfLine = 1;
                    Show_Screen(MainScreenMas, MainScreen, formula_mode);
                    CurrentOperationOnScreen++;
                }

                if (CurrentOperationOnScreen == OperationHistory.Count - 2) CurrentOperationOnScreen = OperationHistory.Count - 1;
            }
        }

        private void EngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_types_of_calculators(false, new string[0], "banner");
        }

        private void LengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_types_of_calculators(true, new string[] { "Нанометры", "Микрометры", "Миллиметры", "Сантиметры", "Метры", "Километры", "Дюймы", "Футы", "Ярды", "Мили", "Морские мили" }, "Длина");
        }

        private void weightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_types_of_calculators(true, new string[] { "Карат", "Миллиграммы", "Сантиграмм", "Дециграммы", "Грамм", "Декаграмм", "Гектограмм", "Килограмм", "Метрические тонны" }, "Вес");
        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_types_of_calculators(true, new string[] { "Сантиметры  в секунду", "Метров в секунду", "Километров в час", "Футы в секунду", "Мили в час", "Узлов" }, "Скорость");
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_types_of_calculators(true, new string[] { "Микросекунд", "Миллисекунд", "Секунд", "Минут", "Часы", "Дней", "Недели", "Года" }, "Время");
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_types_of_calculators(true, new string[] { "Биты", "Байты", "Килобиты","Кибибиты", "Килобайты", "Кибибайты", "Мегабиты", "Мебибиты", "Мегабайты", "Мебибайт", "Гигабит", "Гибибит", "Гигабайт", "Гибибайт"}, "Данные");
        }

        private void change_types_of_calculators(bool conversion_mode_of_type, string[] Items, string banner_text)
        {
            if (!conversion_mode_of_type)
            {
                MoveToolStripMenuItem.Visible = true;
                Screens.Visible = true;
                KeyboardMathOperations.Visible = true;
                ConversionOfValues.Visible = false;
                banner.Visible = false;
                conversion_mode = false;
            }
            else
            {
                MoveToolStripMenuItem.Visible = false;
                Screens.Visible = false;
                KeyboardMathOperations.Visible = false;
                ConversionOfValues.Visible = true;
                banner.Visible = true;
                banner.Text = banner_text;
                conversion_mode = true;
                Conversion_textBox1.Text = "";
                Conversion_textBox2.Text = "";
                Conversion_comboBox1.Text = "";
                Conversion_comboBox2.Text = "";
                Conversion_comboBox1.Items.Clear();
                Conversion_comboBox2.Items.Clear();
                Conversion_comboBox1.Items.AddRange(Items);
                Conversion_comboBox2.Items.AddRange(Items);
            }
        }

        private void Conversion_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate(false);
        }

        private void Conversion_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate(false);
        }
    }
}
