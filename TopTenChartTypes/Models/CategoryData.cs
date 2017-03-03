using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class CategoryData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Month { get; set; }
        public double Temperature { get; set; }
        public double temp2 { get; set; }

    }
}
