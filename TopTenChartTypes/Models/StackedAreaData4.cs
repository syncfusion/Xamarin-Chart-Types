using SQLite;
using System;

namespace Sample
{
    public class StackedAreaData4
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Year { get; set; }
        public double Production { get; set; }

    }
}
