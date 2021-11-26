using Elos_x_CMS.Core.CMS.Interface;
using System;

namespace Elos_x_CMS.Core.CMS
{
    public class CmsConnection : ICmsConnection
    {
        public Uri Url { get; set; }
        public ICmsAuthorizationTokenProvider CmsAuthorizationTokenProvider { get; set; }

        public CmsConnection()
        {

        }

        public CmsConnection(Uri url, ICmsAuthorizationTokenProvider cmsAuthorizationTokenProvider)
        {
            Url = url;
            CmsAuthorizationTokenProvider = cmsAuthorizationTokenProvider;
        }

        public void Dispose()
        {
            
        }
    }
}
