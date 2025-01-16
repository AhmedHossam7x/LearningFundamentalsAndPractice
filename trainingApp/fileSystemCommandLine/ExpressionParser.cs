using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.fileSystemCommandLine
{
    public static class ExpressionParser
    {
        public const string MATHSYMBOLS = "+*^%";
        public static MathExpression Parse(string input)
        {
            input = input.Trim();
            var expr = new MathExpression();
            //1111 + 2222
            //sin 90
            //10 cos 60
            //-1           -  9
            //1+1
            string token = "";
            bool leftFlagSideIntitailized = false;

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if (Char.IsDigit(currentChar))
                {
                    token += currentChar;

                    if (leftFlagSideIntitailized && i == input.Length-1) { 
                        expr.RightSideOperation = double.Parse(token);
                        break;
                    }
                }
                else if (MATHSYMBOLS.Contains(currentChar))
                {
                    if (!leftFlagSideIntitailized)
                    {
                        expr.LeftSideOperation = double.Parse(token);
                        leftFlagSideIntitailized = true;
                    }
                    expr.Operation = ParseMathOperation(currentChar.ToString());
                    token = "";
                }
                else if (currentChar == '-' && i > 0)
                {
                    if (expr.Operation == MathOperation.None)
                    {
                        if (!leftFlagSideIntitailized)
                        {
                            expr.LeftSideOperation = double.Parse(token);
                            leftFlagSideIntitailized = true;
                        }
                        expr.Operation = ParseMathOperation(currentChar.ToString());
                        token = "";
                    }
                    else
                        token += currentChar;
                }
                else if (Char.IsLetter(currentChar))
                {
                    token += currentChar;
                    leftFlagSideIntitailized = true;
                }
                else if (currentChar == ' ')
                {
                    if (!leftFlagSideIntitailized)
                    {
                        expr.LeftSideOperation = double.Parse(token);
                        token = "";
                        leftFlagSideIntitailized = true;
                    }
                    else if (expr.Operation == MathOperation.None)
                    {
                        expr.Operation = ParseMathOperation(token);
                        token = "";
                    }
                }
                else
                {
                    token += currentChar;
                }
            }
            return expr;
        }

        private static MathOperation ParseMathOperation(string token)
        {
            switch (token.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "-":
                    return MathOperation.Subtractition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}
