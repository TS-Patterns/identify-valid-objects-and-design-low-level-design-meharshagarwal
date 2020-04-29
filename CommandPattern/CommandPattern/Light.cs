using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }

        public void DimLight()
        {
            Console.WriteLine("Dim The Light");
        }

        public void BrightenLight()
        {
            Console.WriteLine("Increase the brightness");
        }
    }
}
