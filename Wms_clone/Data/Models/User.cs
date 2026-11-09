using Wms_clone.DataModel;

namespace Wms_clone.Data.Models
{
    public class User
    {
        public uint Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Surname { get; set; } = String.Empty;
        public Role Role { get; set; }
    }
}
