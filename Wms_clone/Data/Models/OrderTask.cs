using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class OrderTask
    {
        public int Id { get; set; }
        public OperationType Type { get; set; }
        public Status Status { get; set; }
        public int AuthorId { get; set; } 
        public User Author { get; set; } = null!;
        public DateTime Date { get; set; }
        public List<StockMovement> Movements { get; set; } = new();
    }
}
