using clipboard-history-manager-windows.Models;

namespace clipboard-history-manager-windows.Contracts
{
    public interface ILinkPreviewService
    {
        void TryLoadLinkMetadata(DataModel dataModel);
    }
}
