namespace Wms_clone.DataModel
{
    public class Category : ICommonObject
    {
        public uint Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; }= String.Empty;
        public List<Category> ContainedIn { get; set; } = new List<Category>();
        public List<Category> Contains { get; set; } = new List<Category>();
    }
}
