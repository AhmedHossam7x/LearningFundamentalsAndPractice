using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.Abstract
{
    internal class Rectangl: Shape
    {
        public Rectangl()
        {
            Name = "My Rectangl";
        }
        public double Lenght { get; set; }
        public double witdh { get; set; }

        public override double Culc()
        {
            return Lenght * witdh;
        }
        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"The area is width:{witdh} * lenght:{Lenght}={Culc()}");
        //}
        public new void Print()
        {
            Console.WriteLine($"The area of \"{Name}\" is width:{witdh} * lenght:{Lenght}={Culc()}");
        }
    }
}
