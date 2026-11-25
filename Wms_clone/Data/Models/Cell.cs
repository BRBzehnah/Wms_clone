using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class Cell : ICommonObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Barcode { get; set; }
        public int? Row { get; set; }
        public int? Rack { get; set; }
        public Zone Zone { get; set; } = null!;
        public List<StockItem> StockItems { get; set; } = new();
        public bool IsBlocked { get; set; }
    }
}
