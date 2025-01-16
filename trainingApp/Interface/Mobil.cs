using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.Interface
{
    internal class Mobil : IDevices, IRestartable
    {
        public void Restar()
        {
            Console.WriteLine("Mobil turn restart");
        }

        public void TurnOff()
        {
            Console.WriteLine("Mobil turn off");
        }

        public void TurnON()
        {
            Console.WriteLine("Mobil turn on");
        }
    }
}
