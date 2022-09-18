using System;
using System.ComponentModel.DataAnnotations;

namespace Boards.PcbManufacturing.ViewModels
{
    public class QuoteEntryViewModel
    {
        public string Group { get; set; }

        [Display(Name = "Parameter Name")]
        public string ParameterName { get; set; }

        [Display(Name = "Parameter Value")]
        public string ParameterValue { get; set; }

        [Display(Name = "Time Impact")]
        public TimeSpan TimeImpact { get; set; }

        [Display(Name = "Cost Impact")]
        public decimal CostImpact { get; set; }
    }
}
