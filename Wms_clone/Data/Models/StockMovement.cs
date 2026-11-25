using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class StockMovement
    {
        public int Id { get; set; }
        public OperationType Type { get; set; }
        public Cell? FromCell { get; set; }
        public Cell? ToCell { get; set; }
        public Product Product { get; set; } = null!;  
        public int Quantity { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
