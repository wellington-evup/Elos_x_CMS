using Elos_x_CMS.Core.CMS.Model;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface ICmsAuthorizationTokenProvider
    {
        CmsAuthorizationToken Provide();
    }
}
