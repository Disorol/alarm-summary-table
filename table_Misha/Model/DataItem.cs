using System;

namespace table_Misha.Model
{
    internal class DataItem
    {
        public string ImageSource { get; set; }
        public DateTime DateAndTime { get; set; }
        public string LocationTag { get; set; }
        public string Source { get; set; }
        public string Condition { get; set; }
        public string Prionity { get; set; }
        public string Description { get; set; }
        public string TripValue { get; set; }
        public string LiveValue { get; set; }
        public string Units { get; set; }
    }
}
