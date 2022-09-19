using System;
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

        public string ParameterName
        { 
            get => _parameterName;
            set
            {
                _parameterName = value;
                OnPropertyChanged();
            }
        }

        public string ParameterValue
        {
            get => _parameterValue;
            set
            {
                _parameterValue = value;
                OnPropertyChanged();
            }
        }

        public TimeSpan TimeImpact 
        { 
            get => _timeImpact; 
            set 
            {
                _timeImpact = value;
                OnPropertyChanged();
            } 
        }

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
