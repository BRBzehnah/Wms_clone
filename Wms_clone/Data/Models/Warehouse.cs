using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class Warehouse : ICommonObject
    {
        public uint Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public double Area { get; set; }
        public List<Zone> Zones { get; set; } = new List<Zone>();
    }
}
