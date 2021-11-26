namespace Elos_x_CMS.Core.Entity
{
    public class OrgStructConfigDefault : BaseDbEntity
    {
        public virtual string Name { get; set; }
        public virtual string DefaultValue { get; set; }
        public virtual string ConfigType { get; set; }
        public virtual bool ApplyToRoot { get; set; }
        public virtual bool ApplyToDomain { get; set; }
        public virtual bool ApplyToLeaf { get; set; }
    }
}