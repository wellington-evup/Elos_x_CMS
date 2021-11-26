using Elos_x_CMS.Core.Interface;
using System;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface ICmsRepository<X> : IRepository<X, Guid>
    {
    }
}
