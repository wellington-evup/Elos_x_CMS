using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;

namespace Elos_x_CMS.Core.CMS.Repository
{
    public class OrganizationalStructureCmsReadonlyRepository : CmsReadonlyRepository<OrganizationalStructureVM, OrganizationalStructureDTO>
    {
        protected override string SchemaName => "organizational-structure";

        public OrganizationalStructureCmsReadonlyRepository(ICmsConnection connection
            , IDtoCmsTranslator<OrganizationalStructureVM, OrganizationalStructureDTO> dtoCmsTranslator) 
            : base(connection, dtoCmsTranslator)
        {
        }
    }
}
