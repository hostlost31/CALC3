using System;
using System.Text;
using System.Windows.Forms;

namespace CALC3
{
    internal class Parser
    {
        private string unit;
        private string input;
        private int position;

        public double Parse(string input, string unit)
        {
            this.input = input;
            this.position = 0;
            this.unit = unit;
            return ParseExpression();
        }

        private double ParseExpression()
        {
            double left = ParseTerm();
            while (true)
            {
                SkipWhiteSpace();
                if (position >= input.Length)
                {
                    return left;
                }
                char op = input[position];
                if (op != '+' && op != '-')
                {
                    return left;
                }
                position++;
                double right = ParseTerm();
                if (op == '+')
                {
                    left += right;
                }
                else
                {
                    left -= right;
                }
            }
        }

        private double ParseTerm()
        {
            double left = ParsePower();

            while (position < input.Length)
            {
                char op = input[position];
                if (op != '*' && op != '/')
                {
                    break;
                }
                position++;

                double right = ParsePower();

                if (op == '*')
                {
                    left *= right;
                }
                else
                {
                    if (right == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    left /= right;
                }
            }

            return left;
        }
        private double ParsePower()
        {
            SkipWhiteSpace();

            if (position >= input.Length)
            {
                MessageBox.Show("Ожидалось число, выражение или функция");
            }

            double left = ParseFactor();

            while (position < input.Length && input[position] == '^')
            {
                position++;
                double right = ParseFactor();
                left = Math.Pow(left, right);
            }

            return left;
        }

        private double ParseFactor()
        {
            SkipWhiteSpace();

            if (position >= input.Length)
            {
                throw new ArgumentException("Ожидалось число, выражение или функция");
            }

            char ch = input[position];

            if (ch == '(')
            {
                position++;
                double expr = ParseExpression();
                SkipWhiteSpace();

                if (position >= input.Length || input[position] != ')')
                {
                    MessageBox.Show("Ожидалась закрывающая скобка");
                }

                position++;
                return expr;
            }

            if (ch == '-')
            {
                position++;
                double factor = ParseFactor();
                return -factor;
            }

            if (ch >= '0' && ch <= '9')
            {
                return ParseNumber();
            }

            if (ch == 'e')
            {
                position++;
                return Math.E;
            }

            if (ch == 'π')
            {
                position++;
                return Math.PI;
            }

            if (ch == 'l' && position + 1 < input.Length && input[position + 1] == 'n')
            {
                position += 2;
                double arg = ParseFactor();
                return Math.Log(arg);
            }

            if (ch == 's')
            {
                if (IsFunction("sinh"))
                {
                    if (position + 4 >= input.Length || !IsFunction("sinh"))
                    {
                        MessageBox.Show("Ожидалась функция sinh");
                    }
                    position += 4;
                    double arg = ParseFactor();
                    return Sinh(arg);
                }
                if (IsFunction("sin"))
                {
                    if (position + 3 >= input.Length || !IsFunction("sin"))
                    {
                        MessageBox.Show("Ожидалась функция sin");
                    }
                    position += 3;
                    double arg = ParseFactor();
                    return Sin(arg);
                }

                if (IsFunction("sech"))
                {
                    if (position + 4 >= input.Length || !IsFunction("sech"))
                    {
                        MessageBox.Show("Ожидалась функция sech");
                    }
                    position += 4;
                    double arg = ParseFactor();
                    return Sech(arg);
                }
                if (IsFunction("sec"))
                {
                    if (position + 3 >= input.Length || !IsFunction("sec"))
                    {
                        MessageBox.Show("Ожидалась функция sec");
                    }
                    position += 3;
                    double arg = ParseFactor();
                    return Sec(arg);
                }

            }
            if (ch == 'c')
            {
                if (IsFunction("cosh"))
                {
                    if (position + 4 >= input.Length || !IsFunction("cosh"))
                    {
                        throw new ArgumentException("Ожидалась функция cosh");
                    }
                    position += 4;
                    double arg = ParseFactor();
                    return Cosh(arg);
                }
                if (IsFunction("cos"))
                {
                    if (position + 3 >= input.Length || !IsFunction("cos"))
                    {
                        throw new ArgumentException("Ожидалась функция cos");
                    }
                    position += 3;
                    double arg = ParseFactor();
                    return Cos(arg);
                }


                if (IsFunction("coth"))
                {
                    if (position + 4 >= input.Length || !IsFunction("coth"))
                    {
                        throw new ArgumentException("Ожидалась функция coth");
                    }
                    position += 4;
                    double arg = ParseFactor();
                    return Coth(arg);
                }
                if (IsFunction("cot"))
                {
                    if (position + 3 >= input.Length || !IsFunction("cot"))
                    {
                        throw new ArgumentException("Ожидалась функция cot");
                    }
                    position += 3;
                    double arg = ParseFactor();
                    return Cot(arg);
                }
                if (IsFunction("csch"))
                {
                    if (position + 4 >= input.Length || !IsFunction("csch"))
                    {
                        throw new ArgumentException("Ожидалась функция csch");
                    }
                    position += 4;
                    double arg = ParseFactor();
                    return Csch(arg);
                }
                if (IsFunction("csc"))
                {
                    if (position + 3 >= input.Length || !IsFunction("csc"))
                    {
                        throw new ArgumentException("Ожидалась функция csc");
                    }
                    position += 3;
                    double arg = ParseFactor();
                    return Csc(arg);
                }



            }
            if (ch == 't')
            {
                if (IsFunction("tanh"))
                {
                    if (position + 4 >= input.Length || !IsFunction("tanh"))
                    {
                        throw new ArgumentException("Ожидалась функция tanh");
                    }
                    position += 4;
                    double arg = ParseFactor();
                    return Tanh(arg);
                }
                if (IsFunction("tan"))
                {
                    if (position + 3 >= input.Length || !IsFunction("tan"))
                    {
                        throw new ArgumentException("Ожидалась функция tan");
                    }
                    position += 3;
                    double arg = ParseFactor();
                    return Tan(arg);
                }
            }

            throw new ArgumentException("Неизвестная функция или оператор");
        }

        private double ParsePrimary()
        {
            SkipWhiteSpace();

            if (position >= input.Length)
            {
                throw new ArgumentException("Ожидалось число или выражение");
            }
            char ch = input[position];
            if (ch == '(')
            {
                position++;
                double expr = ParseExpression();
                SkipWhiteSpace();
                if (position >= input.Length || input[position] != ')')
                {
                    throw new ArgumentException("Ожидалась закрывающая скобка");
                }
                position++;
                return expr;
            }
            if (ch == '-')
            {
                position++;
                double factor = ParseFactor();
                return -factor;
            }
            if (ch >= '0' && ch <= '9')
            {
                return ParseNumber();
            }
            if (ch == 'e')
            {
                position++;
                return Math.E;
            }
            if (ch == '^')
            {
                position++;
                double baseNumber = ParsePrimary();
                double exponent = ParseFactor();
                return Power(baseNumber, exponent);
            }


            if (ch == 'd')
            {
                if (IsUnit("degree"))
                {
                    if (position + 6 >= input.Length || !IsUnit("degree"))
                    {
                        throw new ArgumentException("Ожидалась единица измерения degree");
                    }
                    position += 6;
                    return ParsePrimary() * Math.PI / 180.0;
                }
            }
            if (ch == 'r')
            {
                if (IsUnit("radian"))
                {
                    if (position + 6 >= input.Length || !IsUnit("radian"))
                    {
                        throw new ArgumentException("Ожидалась единица измерения radian");
                    }
                    position += 6;
                    return ParsePrimary();
                }
            }

            throw new ArgumentException("Неизвестное выражение");
        }

        private bool IsFunction(string functionName)
        {
            int length = functionName.Length;
            if (position + length <= input.Length)
            {
                string substr = input.Substring(position, length);
                return substr.Equals(functionName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        private bool IsUnit(string unitName)
        {
            int length = unitName.Length;
            if (position + length <= input.Length)
            {
                string substr = input.Substring(position, length);
                return substr.Equals(unitName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        private double ParseNumber()
        {
            int start = position;
            while (position < input.Length && (char.IsDigit(input[position]) || input[position] == ','))
            {
                position++;
            }

            string numberString = input.Substring(start, position - start);
            return double.Parse(numberString);
        }

        private void SkipWhiteSpace()
        {
            while (position < input.Length && char.IsWhiteSpace(input[position]))
            {
                position++;
            }
        }
        private double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        private double Sin(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return Math.Sin(angle);
        }

        private double Cos(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return Math.Cos(angle);
        }

        private double Tan(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return Math.Tan(angle);
        }

        private double Sinh(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return Math.Sinh(angle);
        }

        private double Cosh(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return Math.Cosh(angle);
        }

        private double Tanh(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return Math.Tanh(angle);
        }

        private double Csc(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return 1 / Math.Sin(angle);
        }

        private double Sec(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return 1 / Math.Cos(angle);
        }

        private double Cot(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return 1 / Math.Tan(angle);
        }

        private double Csch(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return 1 / Math.Sinh(angle);
        }

        private double Sech(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return 1 / Math.Cosh(angle);
        }

        private double Coth(double angle)
        {
            if (unit.Equals("degree", StringComparison.OrdinalIgnoreCase))
            {
                angle = angle * Math.PI / 180.0;
            }
            return 1 / Math.Tanh(angle);
        }

        
    }
}
