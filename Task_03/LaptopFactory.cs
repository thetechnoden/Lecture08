using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class LaptopFactory : IProductFactory
    {
        public IScreen CreateScreen()
        {
            return new LcdScreen();
        }

        public IProcessor CreateProcessor()
        {
            return new AppleProcessor();
        }

        public ICamera CreateCamera()
        {
            return new TripleCamera();
        }
    }
}
