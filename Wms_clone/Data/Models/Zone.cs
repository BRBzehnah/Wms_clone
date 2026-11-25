using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class Zone : ICommonObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Warehouse Warehouse { get; set; } = null!;
        public List<Cell> Cells { get; set; } = new();
    }
}
