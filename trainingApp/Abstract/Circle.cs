using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.Abstract
{
    internal class Circle : Shape
    {
        public Circle()
        {
            Name = "My Circli";
        }
        public double Area { get; set; }
        public override double Culc()
        {
            return Math.PI * Area * Area; 
        }
    }
}
