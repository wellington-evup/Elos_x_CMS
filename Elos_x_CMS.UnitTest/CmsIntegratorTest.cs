using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Provide;
using Elos_x_CMS.Core.CMS.Repository;
using Elos_x_CMS.Core.CMS.Service;
using Elos_x_CMS.Core.CMS.Translator;
using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.DataAccess.Provider;
using Elos_x_CMS.Core.DataAccess.Repository;
using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Interface;
using NUnit.Framework;
using System.Data;
using System.Linq;

namespace Elos_x_CMS.UnitTest
{
    public class CmsIntegratorTest
    {
        ICmsConnection cmsConnection;
        IDbConnection sqlConnection;

        [SetUp]
        public void Setup()
        {
            cmsConnection = new CmsConnectionProvider().Provide();
            sqlConnection = new SqlConnectionProvider().Provide();
        }

        [Test]
        public void GetAll_Success()
        {
            //Arrange
            ICmsTranslator<ContractTemplate, ContractTemplateVM> translator =
                new ContractTemplateTranslator();
            IDtoCmsTranslator<ContractTemplateVM, ContractTemplateDTO> dtoCmsTranslator =
                new ContractTemplateDtoTranslator();
            ISqlReadonlyRepository<ContractTemplate> sqlRepository = new ContractTemplateSqlReadonlyRepository(sqlConnection); 
            ICmsRepository<ContractTemplateVM> cmsRepository = 
                new ContractTemplateCmsRepository(cmsConnection, dtoCmsTranslator);

            var clientChannels = new[]
            {
                new AppChannel() { Code = "ECM_BRA" },
                new AppChannel() { Code = "LP_BRA" },
                new AppChannel() { Code = "APP_AGE" },
            }.ToList();
            var itemCmsIntegrators = new IItemCmsIntegrator[]
            {
                new ContractTemplateCmsIntegrator(sqlRepository, cmsRepository, translator)
            };
            ICmsIntegrator cmsIntegrator = new CmsIntegrator(itemCmsIntegrators);

            //Act
            cmsIntegrator.Integrate(clientChannels);

            //Assert
            Assert.True(true);
        }
    }
}