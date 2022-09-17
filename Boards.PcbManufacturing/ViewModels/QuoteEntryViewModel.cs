using System;

namespace Boards.PcbManufacturing.ViewModels
{
    public class QuoteEntryViewModel
    {
        public string Group { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public TimeSpan TimeImpact { get; set; }
        public decimal CostImpact { get; set; }
    }
}
