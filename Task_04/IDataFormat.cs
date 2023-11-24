using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public interface IDataFormat
    {
        IDataFormat Clone();
        void LoadData(string data);
        string SaveData();
    }

}
