using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main()
        {
            IDataFormat sourceFormat = new CSVFormat();
            IDataFormat targetFormat = new XMLFormat();

            IDataAdapter adapter = new DataFormatAdapter(sourceFormat);

            string inputData = "1,John,Doe\n2,Jane,Smith";
            string outputData = adapter.ConvertData(inputData, targetFormat);

            Console.WriteLine("Input Data:");
            Console.WriteLine(inputData);
            Console.WriteLine("\nOutput Data:");
            Console.WriteLine(outputData);
        }
    }
}