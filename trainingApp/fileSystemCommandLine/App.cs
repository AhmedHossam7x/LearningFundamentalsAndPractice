using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.fileSystemCommandLine
{
    public static class App
    {
        public static void Run(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pls, Enter math Expression: ");

                string input = Console.ReadLine();

                var expr = ExpressionParser.Parse(input);
                Console.WriteLine($"Left side {expr.LeftSideOperation} operation {expr.Operation} right {expr.RightSideOperation}");
                Console.WriteLine($"{input} = {EvaluateExpression(expr)}");
            }
        }
        public static object EvaluateExpression(MathExpression expr)
        {
            if (expr.Operation == MathOperation.Addition)
                return expr.LeftSideOperation + expr.RightSideOperation;
            else if (expr.Operation == MathOperation.Subtractition)
                return expr.LeftSideOperation - expr.RightSideOperation;
            else if (expr.Operation == MathOperation.Multiplication)
                return expr.LeftSideOperation * expr.RightSideOperation;
            else if (expr.Operation == MathOperation.Division)
                return expr.LeftSideOperation / expr.RightSideOperation;
            else if (expr.Operation == MathOperation.Modulus)
                return expr.LeftSideOperation % expr.RightSideOperation;
            else if (expr.Operation == MathOperation.Power)
                return Math.Pow(expr.LeftSideOperation ,expr.RightSideOperation);
            else if (expr.Operation == MathOperation.Sin)
                return Math.Sin(expr.RightSideOperation);
            else if (expr.Operation == MathOperation.Cos)
                return Math.Cos(expr.RightSideOperation);
            else if (expr.Operation == MathOperation.Power)
                return Math.Tan(expr.RightSideOperation);
            return 0;
        }
    }
}
