using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;
using System;

namespace Elos_x_CMS.Core.CMS.Repository
{
    public class ContractTemplateCmsRepository : ContractTemplateCmsReadonlyRepository, ICmsRepository<ContractTemplateVM>
    {
        public ContractTemplateCmsRepository(ICmsConnection connection
            , IDtoCmsTranslator<ContractTemplateVM, ContractTemplateDTO> dtoCmsTranslator) 
            : base(connection, dtoCmsTranslator)
        {
        }

        public void Insert(ContractTemplateVM model)
        {
            throw new NotImplementedException();
        }

        public void Update(ContractTemplateVM model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
