using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public class CSVFormat : IDataFormat
    {
        private List<string[]> data = new List<string[]>();

        public IDataFormat Clone()
        {
            return new CSVFormat();
        }

        public void LoadData(string data)
        {
            string[] rows = data.Split('\n');
            foreach (var row in rows)
            {
                this.data.Add(row.Split(','));
            }
        }

        public string SaveData()
        {
            List<string> serializedData = new List<string>();
            foreach (var row in data)
            {
                serializedData.Add(string.Join(",", row));
            }
            return string.Join("\n", serializedData);
        }
    }
}
