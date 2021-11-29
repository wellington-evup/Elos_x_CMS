using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Enum;
using Elos_x_CMS.Core.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Elos_x_CMS.Core.CMS.Service
{
    public class ContractTemplateCmsIntegrator : BaseItemCmsIntegrator<ContractTemplate, ContractTemplateVM>
    {
        private static readonly AppChannel[] _channels = new[]
        {
            new AppChannel() { Code = "ECM_BRA" },
            new AppChannel() { Code = "LP_BRA" },
        };

        public ContractTemplateCmsIntegrator(
            ISqlReadonlyRepository<ContractTemplate> sqlReadonlyRepository,
            ICmsRepository<ContractTemplateVM> cmsRepository,
            ICmsTranslator<ContractTemplate, ContractTemplateVM> translator) 
            : base(sqlReadonlyRepository, cmsRepository, translator, _channels)
        {

        }

        public override IEnumerable<ContractTemplate> GetItemsToIntegrate()
        {
            return SqlReadonlyRepository.GetAll()
                .Where(x => !x.Inactive)
                .Where(x => x.Type == EContractTemplateType.ConsentTerm || x.Type == EContractTemplateType.FidelityProgramTerm);
        }
    }
}
