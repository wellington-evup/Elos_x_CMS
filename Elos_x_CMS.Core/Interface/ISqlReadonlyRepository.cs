using System;
using System.Collections.Generic;
using System.Text;

namespace Elos_x_CMS.Core.Interface
{
    public interface ISqlReadonlyRepository<X> : IReadonlyRepository<X, long>
    {
    }
}
