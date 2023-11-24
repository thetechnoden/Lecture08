using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public class XMLFormat : IDataFormat
    {
        private string data = "";

        public IDataFormat Clone()
        {
            return new XMLFormat();
        }

        public void LoadData(string data)
        {
            this.data = data;
        }

        public string SaveData()
        {
            return data;
        }
    }
}
