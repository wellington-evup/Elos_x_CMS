using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Interface;
using System.Data;

namespace Elos_x_CMS.Core.DataAccess.Repository
{
    public class ContractTemplateSqlRepository : ContractTemplateSqlReadonlyRepository, ISqlRepository<ContractTemplate>
    {
        public ContractTemplateSqlRepository(IDbConnection connection) : base(connection)
        {
        }

        public void Insert(ContractTemplate model)
        {
            throw new System.NotImplementedException();
        }

        public void Update(ContractTemplate model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
