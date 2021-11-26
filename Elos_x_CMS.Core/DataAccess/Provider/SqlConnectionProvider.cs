using Elos_x_CMS.Core.DataAccess.Interface;
using System.Data;
using System.Data.SqlClient;

namespace Elos_x_CMS.Core.DataAccess.Provider
{
    public class SqlConnectionProvider : ISqlConnectionProvider
    {
        public IDbConnection Provide()
        {
            return new SqlConnection("");
        }
    }
}
