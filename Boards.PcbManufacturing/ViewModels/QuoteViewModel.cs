using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Boards.PcbManufacturing.BaseModel;

namespace Boards.PcbManufacturing.ViewModels
{
    public class QuoteViewModel : ViewModelBase
    {
        private ObservableCollection<QuoteEntryViewModel> _quoteEntries;

        public QuoteViewModel()
        {
            this.Summary = new QuoteEntryViewModel();
            _quoteEntries = new ObservableCollection<QuoteEntryViewModel>();
        }

        private void OnQuoteEntriesCollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (sender is not ObservableCollection<QuoteEntryViewModel> collection)
            {
                return;
            }

            var daysTotal = TimeSpan.FromTicks(collection.Sum(x => x.TimeImpact.Ticks));
            var costTotal = collection.Sum(x => x.CostImpact);
            this.Summary.TimeImpact = daysTotal;
            this.Summary.CostImpact = costTotal;
        }

        public ObservableCollection<QuoteEntryViewModel> QuoteEntries 
        { 
            get => _quoteEntries;
            set
            {
                _quoteEntries = value;
                if (_quoteEntries != null)
                {
                    _quoteEntries.CollectionChanged += OnQuoteEntriesCollectionChanged;
                    OnQuoteEntriesCollectionChanged(value, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                    this.OnPropertyChanged();
                }
            }
        }

        public QuoteEntryViewModel Summary { get; }
    }
}
