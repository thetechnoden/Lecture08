using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class OledScreen : IScreen
    {
        public string GetDescription()
        {
            return "OLED Screen";
        }
    }
}
