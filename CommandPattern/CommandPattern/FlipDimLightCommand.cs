using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class FlipDimLightCommand : ICommand
    {
        private Light _light;

        public FlipDimLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.DimLight();
        }
    }
}
