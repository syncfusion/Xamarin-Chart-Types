using SQLite;
using System;

namespace Sample
{
    public class RadarData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Type { get; set; }
        public double AmountSpent { get; set; }
        public double Other { get; set; }
        public double third { get; set; }
    }
}
