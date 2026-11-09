using Wms_clone.DataModel;

namespace Wms_clone.Data
{
    public class Zone : ICommonObject
    {
        public uint Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public List<Cell> Cells { get; set; } = new List<Cell>();
    }
}
