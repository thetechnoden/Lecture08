using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class GraphClient
    {
        static void Main()
        {
            Dictionary<string, IGraphFactory> graphFactories = new Dictionary<string, IGraphFactory>
        {
            { "line", new LineGraphFactory() },
            { "bar", new BarGraphFactory() },
            { "pie", new PieChartFactory() }
        };

            Console.WriteLine("Enter the type of graph (line, bar, pie): ");
            string graphType = Console.ReadLine()?.ToLower() ?? string.Empty;

            if (graphFactories.TryGetValue(graphType, out var graphFactory))
            {
                IGraph graph = graphFactory.CreateGraph();
                graph.Draw();
            }
            else
            {
                Console.WriteLine("Invalid graph type");
            }
        }
    }
}