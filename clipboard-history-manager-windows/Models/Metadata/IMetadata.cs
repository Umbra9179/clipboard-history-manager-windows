using System.ComponentModel;

namespace clipboard-history-manager-windows.Models.Metadata
{
    public interface IMetadata
    {
        MetadataFormat Format { get; }
    }

    public enum MetadataFormat
    {
        [Description("Link")]
        Link,

        [Description("Color")]
        Color,

        [Description("Files")]
        Files
    }
}
