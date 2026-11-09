using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class Cell : ICommonObject
    {
        public uint Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int Row { get; set; }
        public int Rack { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
