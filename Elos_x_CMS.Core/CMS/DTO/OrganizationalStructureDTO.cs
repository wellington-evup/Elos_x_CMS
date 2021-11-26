using Elos_x_CMS.Core.CMS.Model;

namespace Elos_x_CMS.Core.CMS.DTO
{
    public class OrganizationalStructureDTO : CmsBaseDTO
    {
        public CmsField<string> description { get; set; }
        public CmsField<bool> isRoot { get; set; }
        public CmsField<bool> isLeaf { get; set; }
        public CmsField<bool> isDomain { get; set; }
    }
}
