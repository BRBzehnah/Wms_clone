using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class StockItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int CellId { get; set; }
        public Cell Cell { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
