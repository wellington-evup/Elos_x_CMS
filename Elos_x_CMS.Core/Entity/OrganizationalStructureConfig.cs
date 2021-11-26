namespace Elos_x_CMS.Core.Entity
{
    public class OrganizationalStructureConfig : BaseDbEntity
    {
        public virtual OrganizationalStructure OrganizationalStructure { get; set; }
        public virtual string Value { get; set; }
        public virtual OrgStructConfigDefault Config { get; set; }
    }
}
