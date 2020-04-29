using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class FlipBrightenLightCommand :ICommand
    {
        private Light _light;

        public FlipBrightenLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.BrightenLight();
        }
    }

}
