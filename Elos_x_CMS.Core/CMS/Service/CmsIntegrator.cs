using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Elos_x_CMS.Core.CMS.Service
{
    public class CmsIntegrator : ICmsIntegrator
    {
        public List<IItemCmsIntegrator> ItemCmsIntegrators { get; private set; }

        public CmsIntegrator(params IItemCmsIntegrator[] itemCmsIntegrators)
        {
            ItemCmsIntegrators = itemCmsIntegrators.ToList();
        }

        public void Integrate(List<AppChannel> clientChannels)
        {
            foreach (var item in ItemCmsIntegrators)
            {
                var isAbleToIntegrate = IsAbleToIntegrate(clientChannels, item);
                if (!isAbleToIntegrate) continue;

                item.Integrate();
            }
        }

        private bool IsAbleToIntegrate(List<AppChannel> clientChannels, IItemCmsIntegrator itemCmsIntegrator)
        {
            return clientChannels.Select(x => x.Code).Intersect(itemCmsIntegrator.Channels.Select(x => x.Code)).Any();
        }
    }
}
