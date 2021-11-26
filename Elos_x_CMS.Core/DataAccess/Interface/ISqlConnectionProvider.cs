using System.Data;

namespace Elos_x_CMS.Core.DataAccess.Interface
{
    public interface ISqlConnectionProvider
    {
        IDbConnection Provide();
    }
}
