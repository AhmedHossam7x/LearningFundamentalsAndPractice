using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.Interface
{
    internal class Computer : IDevices, IRestartable
    {
        public void Restar()
        {
            Console.WriteLine("Computer turn restart");
        }

        public void TurnOff()
        {
            Console.WriteLine("Computer turn off");
        }

        public void TurnON()
        {
            Console.WriteLine("Computer turn on");
        }
    }
}
