using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;

namespace Elos_x_CMS.Core.CMS.Provide
{
    public class CmsAuthorizationTokenProvider : ICmsAuthorizationTokenProvider
    {
        public CmsAuthorizationToken Provide()
        {
            return new CmsAuthorizationToken("");
        }
    }
}
