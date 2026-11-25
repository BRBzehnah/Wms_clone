using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class Warehouse : ICommonObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public double Area { get; set; }
        public List<Zone> Zones { get; set; } = new();
    }
}
