using CommunityToolkit.Mvvm.ComponentModel;
using clipboard-history-manager-windows.Core;
using clipboard-history-manager-windows.Models.Metadata;

namespace clipboard-history-manager-windows.Models
{
    public partial class DataModel(ClipboardFormat format, string data, byte[] hash) : ObservableObject
    {
        public int Id { get; set; }

        public ClipboardFormat Format { get; set; } = format;

        /// <summary>
        /// Contains only string text or absolute path to the file
        /// </summary>
        public string Data { get; set; } = data;

        /// <summary>
        /// Hash of the <see cref="Data"/> content
        /// </summary>
        public byte[] Hash { get; set; } = hash;

        [ObservableProperty]
        public partial IMetadata? Metadata { get; set; }
    }
}
