using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;

namespace Elos_x_CMS.Core.CMS.Repository
{
    public class ContractTemplateCmsReadonlyRepository : CmsReadonlyRepository<ContractTemplateVM, ContractTemplateDTO>
    {
        protected override string SchemaName => "contract-template";

        public ContractTemplateCmsReadonlyRepository(ICmsConnection connection
            , IDtoCmsTranslator<ContractTemplateVM, ContractTemplateDTO> dtoCmsTranslator) 
            : base(connection, dtoCmsTranslator)
        {
        }
    }
}
