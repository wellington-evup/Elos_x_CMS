using Dapper;
using Elos_x_CMS.Core.Entity;
using System.Collections.Generic;
using System.Data;

namespace Elos_x_CMS.Core.DataAccess.Repository
{
    public class ContractTemplateSqlReadonlyRepository : SqlReadonlyRepository<ContractTemplate>
    {
        protected readonly string _fields = "Id, Description, Template, Inactive, Type";

        public ContractTemplateSqlReadonlyRepository(IDbConnection connection) : base(connection)
        {
        }

        public override ContractTemplate Get(long id)
        {
            return Connection.QueryFirstOrDefault<ContractTemplate>($"select { _fields } from sch7.ContractTemplate where Id = @id", new { id });
        }

        public override IEnumerable<ContractTemplate> GetAll()
        {
            return Connection.Query<ContractTemplate>($"select { _fields } from sch7.ContractTemplate");
        }
    }
}
