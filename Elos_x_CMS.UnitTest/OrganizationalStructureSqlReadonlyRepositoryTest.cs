using Elos_x_CMS.Core.DataAccess.Provider;
using Elos_x_CMS.Core.DataAccess.Repository;
using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Interface;
using NUnit.Framework;
using System.Data;

namespace Elos_x_CMS.UnitTest
{
    public class OrganizationalStructureSqlReadonlyRepositoryTest
    {
        IDbConnection connection;

        [SetUp]
        public void Setup()
        {
            connection = new SqlConnectionProvider().Provide();
        }

        [Test]
        public void GetAll_Success()
        {
            //Arrange
            ISqlReadonlyRepository<OrganizationalStructure> repository = new OrganizationalStructureSqlReadonlyRepository(connection);

            //Act
            var all = repository.GetAll();

            //Assert
            Assert.True(true);
        }
    }
}