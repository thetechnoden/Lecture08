using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class SmartphoneFactory : IProductFactory
    {
        public IScreen CreateScreen()
        {
            return new OledScreen();
        }

        public IProcessor CreateProcessor()
        {
            return new SnapdragonProcessor();
        }

        public ICamera CreateCamera()
        {
            return new DualCamera();
        }
    }
}
