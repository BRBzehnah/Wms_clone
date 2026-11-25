using Wms_clone.Data.Models;

namespace Wms_clone.DataModel
{
    public class Category : ICommonObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
