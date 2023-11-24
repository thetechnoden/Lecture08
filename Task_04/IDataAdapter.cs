using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public interface IDataAdapter
    {
        string ConvertData(string input, IDataFormat targetFormat);
    }
}
