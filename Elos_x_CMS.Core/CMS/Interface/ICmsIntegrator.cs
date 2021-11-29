using Elos_x_CMS.Core.Entity;
using System.Collections.Generic;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface ICmsIntegrator
    {
        List<IItemCmsIntegrator> ItemCmsIntegrators { get; }

        public void Integrate(List<AppChannel> clientChannels);
    }
}
