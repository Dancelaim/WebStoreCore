using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class OchvRecurring
    {
        public int RecurringId { get; set; }
        public decimal Price { get; set; }
        public string Frequency { get; set; }
        public int Duration { get; set; }
        public int Cycle { get; set; }
        public byte TrialStatus { get; set; }
        public decimal TrialPrice { get; set; }
        public string TrialFrequency { get; set; }
        public int TrialDuration { get; set; }
        public int TrialCycle { get; set; }
        public byte Status { get; set; }
        public int SortOrder { get; set; }
    }
}
