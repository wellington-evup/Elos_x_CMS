using Dapper;
using Elos_x_CMS.Core.Entity;
using System.Collections.Generic;
using System.Data;

namespace Elos_x_CMS.Core.DataAccess.Repository
{
    public class OrganizationalStructureSqlReadonlyRepository : SqlReadonlyRepository<OrganizationalStructure>
    {
        private readonly string _fields = "Id, Description, IsRoot, IsLeaf, IsDomain";

        public OrganizationalStructureSqlReadonlyRepository(IDbConnection connection) : base(connection)
        {
        }

        public override OrganizationalStructure Get(long id)
        {
            return Connection.QueryFirstOrDefault<OrganizationalStructure>($"select { _fields } from sch8.OrganizationalStructure where Id = @id", new { id });
        }

        public override IEnumerable<OrganizationalStructure> GetAll()
        {
            return Connection.Query<OrganizationalStructure>($"select { _fields } from sch8.OrganizationalStructure");
        }
    }
}
