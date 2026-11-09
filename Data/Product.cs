using Wms_clone.DataModel;

namespace Wms_clone.Data
{
    public class Product : ICommonObject
    {
        public uint Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public byte[] Photo { get; set; } = new byte[0];
        public Uom Unit { get; set; }
        public ICategory? Category { get; set; }
        public int Quantity { get; set; }
        
    }
}
