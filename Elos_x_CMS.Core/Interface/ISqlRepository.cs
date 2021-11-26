using System;
using System.Collections.Generic;
using System.Text;

namespace Elos_x_CMS.Core.Interface
{
    public interface ISqlRepository<X> : IRepository<X, long>, ISqlReadonlyRepository<X>
    {
    }
}
