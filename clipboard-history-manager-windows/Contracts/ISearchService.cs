using clipboard-history-manager-windows.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace clipboard-history-manager-windows.Contracts
{
    public interface ISearchService
    {
        void StartSearch(IEnumerable<ClipModel> items, string searchString, ObservableCollection<ClipModel> foundItems);
        void StopSearch();
    }
}
