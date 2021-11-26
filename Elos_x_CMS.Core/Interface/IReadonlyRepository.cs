using System;
using System.Collections.Generic;
using System.Text;

namespace Elos_x_CMS.Core.Interface
{
    public interface IReadonlyRepository<X, Y> : IDisposable
    {
        X Get(Y id);
        IEnumerable<X> GetAll();
    }
}
