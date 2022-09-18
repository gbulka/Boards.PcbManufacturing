using System;
using System.ComponentModel.DataAnnotations;
using Boards.PcbManufacturing.BaseModel;

namespace Boards.PcbManufacturing.ViewModels
{
    public class QuoteEntryViewModel : ViewModelBase
    {
        private string _parameterName;
        private string _parameterValue;
        private TimeSpan _timeImpact;
        private decimal _costImpact;

        public string Group { get; set; }

        [Display(Name = "Parameter Name")]
        public string ParameterName
        { 
            get => _parameterName;
            set
            {
                _parameterName = value;
                OnPropertyChanged();
            }
        }

        [Display(Name = "Parameter Value")]
        public string ParameterValue
        {
            get => _parameterValue;
            set
            {
                _parameterValue = value;
                OnPropertyChanged();
            }
        }

        [Display(Name = "Time Impact")]
        public TimeSpan TimeImpact 
        { 
            get => _timeImpact; 
            set 
            {
                _timeImpact = value;
                OnPropertyChanged();
            } 
        }

        [Display(Name = "Cost Impact")]
        public decimal CostImpact 
        { 
            get => _costImpact; 
            set
            {
                _costImpact = value;
                OnPropertyChanged();
            } 
        }
    }
}
