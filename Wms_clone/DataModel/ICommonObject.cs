namespace Wms_clone.DataModel
{
    public interface ICommonObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
