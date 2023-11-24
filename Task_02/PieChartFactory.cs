using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class PieChartFactory : IGraphFactory
    {
        public IGraph CreateGraph()
        {
            return new PieChart();
        }
    }
}
