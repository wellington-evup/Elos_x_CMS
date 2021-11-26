using Elos_x_CMS.Core.Interface;

namespace Elos_x_CMS.Core.Entity
{
    public class OrganizationalStructure : BaseDbEntity, IActivable
    {
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public bool IsDomain { get; set; }
    }
}
