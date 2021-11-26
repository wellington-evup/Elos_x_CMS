using Elos_x_CMS.Core.Enum;
using Elos_x_CMS.Core.Interface;

namespace Elos_x_CMS.Core.Entity
{
    public class ContractTemplate : BaseDbEntity, IActivable
    {
        public string Description { get; set; }
        public string Template { get; set; }
        public bool Inactive { get; set; }
        public EContractTemplateType? Type { get; set; }
    }
}
