using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Elos_x_CMS.Core.Extension;
using Elos_x_CMS.Core.CMS.DTO;

namespace Elos_x_CMS.Core.CMS.Repository
{
    public abstract class CmsReadonlyRepository<T, U> : ICmsReadonlyRepository<T> where T : BaseCmsViewModel where U : CmsBaseDTO
    {
        protected ICmsConnection Connection { get; private set; }
        protected IDtoCmsTranslator<T, U> DtoCmsTranslator { get; private set; }
        protected abstract string SchemaName { get; }

        public CmsReadonlyRepository(ICmsConnection connection, IDtoCmsTranslator<T, U> dtoCmsTranslator)
        {
            Connection = connection;
            DtoCmsTranslator = dtoCmsTranslator;
        }

        public virtual T Get(Guid id)
        {
            var cmsResponse = CallApiGet($"id eq '{id}'").Result;
            if(cmsResponse.total == 0)
            {
                return null;
            }
            else
            {
                return DtoCmsTranslator.Translate(cmsResponse.items.First());
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            var cmsResponse = CallApiGet().Result;
            return DtoCmsTranslator.Translate(cmsResponse.items);
        }

        public virtual void Dispose()
        {
            Connection.Dispose();
        }

        protected async Task<CmsResponse<U>> CallApiGet(string filterQuery = null)
        {
            var requestUri = $"{Connection.Url}/{SchemaName}";
            if (true)
            {
                requestUri = $"{requestUri}/?$filter={filterQuery}"; 
            }

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer { Connection.CmsAuthorizationTokenProvider.Provide().Value }");
                httpClient.DefaultRequestHeaders.Add("X-Unpublished", "true");

                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                using (var response = await httpClient.GetAsync(requestUri))
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<CmsResponse<U>>(json);
                }
            }
        }
    }
}
