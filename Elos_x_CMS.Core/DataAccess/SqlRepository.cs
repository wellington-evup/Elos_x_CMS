using Elos_x_CMS.Core.Entity;
using System.Data;

namespace Elos_x_CMS.Core.DataAccess
{
    public abstract class SqlRepository<T> : SqlReadonlyRepository<T> where T : BaseDbEntity
    {
        public SqlRepository(IDbConnection connection) : base(connection)
        {
        }
    }
}
