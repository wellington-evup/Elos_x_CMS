using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;

namespace Elos_x_CMS.Core.CMS.Translator
{
    public class OrganizationalStructureDtoTranslator : IDtoCmsTranslator<OrganizationalStructureVM, OrganizationalStructureDTO>
    {
        public CmsRecord<OrganizationalStructureDTO> Translate(OrganizationalStructureVM value)
        {
            return new CmsRecord<OrganizationalStructureDTO>()
            {
                id = value.Id.ToString(),
                data =
                {
                    description = new Model.CmsField<string>(value.Description),
                    isDomain = new Model.CmsField<bool>(value.IsDomain),
                    isLeaf = new Model.CmsField<bool>(value.IsLeaf),
                    isRoot = new Model.CmsField<bool>(value.IsRoot),
                }
            };
        }

        public OrganizationalStructureVM Translate(CmsRecord<OrganizationalStructureDTO> value)
        {
            return new OrganizationalStructureVM()
            {
                Id = System.Guid.Parse(value.id),
                Description = value.data.description.iv,
                IsDomain = value.data.isDomain.iv,
                IsLeaf = value.data.isLeaf.iv,
                IsRoot = value.data.isRoot.iv
            };
        }
    }
}
