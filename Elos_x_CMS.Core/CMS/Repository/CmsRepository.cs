using Elos_x_CMS.Core.CMS.DTO;
using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;
using System;

namespace Elos_x_CMS.Core.CMS.Repository
{
    public abstract class CmsRepository<T, U> : CmsReadonlyRepository<T, U>, ICmsRepository<T> where T : BaseCmsViewModel where U : CmsBaseDTO
    {
        public CmsRepository(ICmsConnection connection, IDtoCmsTranslator<T, U> dtoCmsTranslator) 
            : base(connection, dtoCmsTranslator)
        {
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T model)
        {
            throw new NotImplementedException();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
