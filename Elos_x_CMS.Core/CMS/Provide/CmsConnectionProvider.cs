using Elos_x_CMS.Core.CMS.Interface;

namespace Elos_x_CMS.Core.CMS.Provide
{
    public class CmsConnectionProvider
    {
        public ICmsConnection Provide()
        {
            return new CmsConnection()
            {
                Url = new System.Uri("https://cms-hml.evup.com.br/api/content/shared-maiscabello"),
                CmsAuthorizationTokenProvider = new CmsAuthorizationTokenProvider()
            };
        }
    }
}
