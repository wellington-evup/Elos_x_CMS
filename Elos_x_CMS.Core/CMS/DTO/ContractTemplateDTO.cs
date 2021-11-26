using Elos_x_CMS.Core.CMS.Model;

namespace Elos_x_CMS.Core.CMS.DTO
{
    public class ContractTemplateDTO : CmsBaseDTO
    {
        public CmsField<string> Description { get; set; }
        public CmsField<string> templateContent { get; set; }
        public CmsField<long?> type { get; set; }
    }
}
