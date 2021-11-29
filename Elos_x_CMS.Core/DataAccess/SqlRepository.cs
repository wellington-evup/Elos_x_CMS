using Dapper;
using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Interface;
using System.Collections.Generic;
using System.Data;

namespace Elos_x_CMS.Core.DataAccess
{
    public abstract class SqlRepository<T> : ISqlRepository<T> where T : BaseDbEntity
    {
        protected IDbConnection Connection { get; private set; }

        public SqlRepository(IDbConnection connection)
        {
            Connection = connection;
        }

        public virtual T Get(long id)
        {
            return Connection.QueryFirstOrDefault<T>($"select * from sch1.{ typeof(T).Name } where Id = @id", new { id });
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Connection.Query<T>($"select * from sch1.{ typeof(T).Name }");
        }

        public virtual void Dispose()
        {
            Connection.Dispose();
        }

        public abstract void Insert(T model);
        public abstract void Update(T model);
        public abstract void Delete(long id);
    }
}
