using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Interface;

namespace Elos_x_CMS.Core.CMS.Service
{
    public class OrganizationalStructureCmsIntegrator : BaseItemCmsIntegrator<OrganizationalStructure, OrganizationalStructureVM>
    {
        private static readonly AppChannel[] _channels = new[]
        {
            new AppChannel() { Code = "ECM_BRA" },
            new AppChannel() { Code = "LP_BRA" },
        };

        public OrganizationalStructureCmsIntegrator(
            ISqlReadonlyRepository<OrganizationalStructure> sqlReadonlyRepository,
            ICmsRepository<OrganizationalStructureVM> cmsRepository,
            ICmsTranslator<OrganizationalStructure, OrganizationalStructureVM> translator) 
            : base(sqlReadonlyRepository, cmsRepository, translator, _channels)
        {

        }
    }
}
