using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;

namespace Elos_x_CMS.Core.CMS.Translator
{
    public class ContractTemplateDtoTranslator : IDtoCmsTranslator<ContractTemplateVM, ContractTemplateDTO>
    {
        public CmsRecord<ContractTemplateDTO> Translate(ContractTemplateVM value)
        {
            return new CmsRecord<ContractTemplateDTO>()
            {
                id = value.Id.ToString(),
                data = new ContractTemplateDTO()
                {
                    Id = new CmsField<long>(value.IdElos),
                    Description = new Model.CmsField<string>(value.Description),
                    templateContent = new Model.CmsField<string>(value.Description),
                    type = new Model.CmsField<long?>(value.Type)
                }
            };
        }

        public ContractTemplateVM Translate(CmsRecord<ContractTemplateDTO> value)
        {
            return new ContractTemplateVM()
            {
                Id = System.Guid.Parse(value.id),
                IdElos = value.data.Id.iv,
                Description = value.data.Description.iv,
                Template = value.data.templateContent.iv,
                Type = value.data.type?.iv
            };
        }
    }
}
