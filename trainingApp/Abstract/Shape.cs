using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.Abstract
{
    public abstract class Shape
    {
        protected string Name { get; set; }
        public abstract double Culc();
        //public virtual void Print()
        //{
        //    Console.WriteLine($"The Area of {Name} is {Culc()}");
        //}
        public void Print()
        {
            Console.WriteLine($"The Area of {Name} is {Culc()}");
        }
    }
}
