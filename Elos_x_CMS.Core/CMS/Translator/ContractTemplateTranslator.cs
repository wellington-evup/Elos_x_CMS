using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.Entity;
using System;

namespace Elos_x_CMS.Core.CMS.Translator
{
    public class ContractTemplateTranslator : ICmsTranslator<ContractTemplate, ContractTemplateVM>
    {
        public ContractTemplateVM Translate(ContractTemplate value)
        {
            return new ContractTemplateVM()
            {
                IdElos = value.Id,
                Description = value.Description,
                Template = value.Template,
                Type = (int)value.Type
            };
        }

        public ContractTemplate Translate(ContractTemplateVM value)
        {
            return new ContractTemplate()
            {
                Id = value.IdElos,
                Description = value.Description,
                Template = value.Template,
                Type = (Enum.EContractTemplateType)value.Type
            };
        }
    }
}
