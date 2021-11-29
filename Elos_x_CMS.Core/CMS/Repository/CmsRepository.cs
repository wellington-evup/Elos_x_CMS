using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Elos_x_CMS.Core.CMS.Repository
{
    public abstract class CmsRepository<T, U> : CmsReadonlyRepository<T, U>, ICmsRepository<T> where T : BaseCmsViewModel where U : CmsBaseDTO
    {
        public CmsRepository(ICmsConnection connection, IDtoCmsTranslator<T, U> dtoCmsTranslator) 
            : base(connection, dtoCmsTranslator)
        {
        }

        public void Insert(T model)
        {
            var m = DtoCmsTranslator.Translate(model);
            CallApiPost(m).Wait();
        }

        public void Update(T model)
        {
            var m = DtoCmsTranslator.Translate(model);
            CallApiPut(m).Wait();
        }

        public void Delete(Guid id)
        {
            CallApiDelete(id).Wait();
        }

        protected async Task<CmsResponse<U>> CallApiPost(CmsRecord<U> model)
        {
            var requestUri = $"{Connection.Url}/{SchemaName}/?publish=true";
            var httpContent = new StringContent(JsonConvert.SerializeObject(model.data), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer { Connection.CmsAuthorizationTokenProvider.Provide().Value }");

                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                using (var response = await httpClient.PostAsync(requestUri, httpContent))
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<CmsResponse<U>>(json);
                }
            }
        }

        protected async Task<CmsResponse<U>> CallApiPut(CmsRecord<U> model)
        {
            var requestUri = $"{Connection.Url}/{SchemaName}/{model.id}";
            var httpContent = new StringContent(JsonConvert.SerializeObject(model.data), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer { Connection.CmsAuthorizationTokenProvider.Provide().Value }");

                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                using (var response = await httpClient.PutAsync(requestUri, httpContent))
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<CmsResponse<U>>(json);
                }
            }
        }

        protected async Task<CmsResponse<U>> CallApiDelete(Guid id)
        {
            var requestUri = $"{Connection.Url}/{SchemaName}/{id}/status/";
            var httpContent = new StringContent(JsonConvert.SerializeObject(new { Status = "Archived" }), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer { Connection.CmsAuthorizationTokenProvider.Provide().Value }");

                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

                using (var response = await httpClient.PutAsync(requestUri, httpContent))
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<CmsResponse<U>>(json);
                }
            }
        }
    }
}
