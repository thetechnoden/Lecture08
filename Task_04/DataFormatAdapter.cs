using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public class DataFormatAdapter : IDataAdapter
    {
        private IDataFormat sourceFormat;

        public DataFormatAdapter(IDataFormat sourceFormat)
        {
            this.sourceFormat = sourceFormat;
        }

        public string ConvertData(string input, IDataFormat targetFormat)
        {
            sourceFormat.LoadData(input);
            return targetFormat.SaveData();
        }
    }
}
