using System;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface ICmsConnection : IDisposable
    {
        public Uri Url { get; }
        public ICmsAuthorizationTokenProvider CmsAuthorizationTokenProvider { get; }
    }
}
