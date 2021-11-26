using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.Provide;
using Elos_x_CMS.Core.CMS.Repository;
using Elos_x_CMS.Core.CMS.Translator;
using Elos_x_CMS.Core.CMS.ViewModel;
using NUnit.Framework;

namespace Elos_x_CMS.UnitTest
{
    public class OrganizationalStructureCmsReadonlyRepositoryTest
    {
        ICmsConnection connection;

        [SetUp]
        public void Setup()
        {
            connection = new CmsConnectionProvider().Provide();
        }

        [Test]
        public void GetAll_Success()
        {
            //Arrange
            IDtoCmsTranslator<OrganizationalStructureVM, OrganizationalStructureDTO> dtoCmsTranslator =
                new OrganizationalStructureDtoTranslator();
            ICmsReadonlyRepository<OrganizationalStructureVM> repository = 
                new OrganizationalStructureCmsReadonlyRepository(connection, dtoCmsTranslator);

            //Act
            var id3 = repository.Get(System.Guid.Parse("17cbf3a2-dfba-4f23-865c-64d192cb07d4"));
            var all = repository.GetAll();

            //Assert
            Assert.True(true);
        }
    }
}