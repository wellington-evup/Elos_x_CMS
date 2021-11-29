using Elos_x_CMS.Core.Entity;
using System.Collections.Generic;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface IItemCmsIntegrator
    {
        List<AppChannel> Channels { get; }

        void Integrate();
    }
}
