using System.Collections.ObjectModel;

namespace Boards.PcbManufacturing.ViewModels
{
    public class QuoteViewModel
    {
        public ObservableCollection<QuoteEntryViewModel> QuoteEntries { get; set; }
    }
}
