using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFundamentals.trainingApp.Interface
{
    internal class LightBulb : IDevices
    {
        public void TurnOff()
        {
            Console.WriteLine("Blub turn off [Blub]");
        }

        public void TurnON()
        {
            Console.WriteLine("Blub turn on [Blub]");
        }

        void IDevices.TurnOff()
        {
            Console.WriteLine("Blub turn off [explicit]");
        }
    }
}
