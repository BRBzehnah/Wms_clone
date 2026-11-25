using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class Product : ICommonObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Barcode { get; set; } = null!;
        public byte[] Photo { get; set; } = new byte[0];
        public Uom Unit { get; set; }
        public Category? Category { get; set; }
        public List<StockItem> StockItems { get; set; } = new();
    }
}
