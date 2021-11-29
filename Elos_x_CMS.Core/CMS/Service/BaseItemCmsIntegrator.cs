using Elos_x_CMS.Core.CMS.Interface;
using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.Entity;
using Elos_x_CMS.Core.Extension;
using Elos_x_CMS.Core.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Elos_x_CMS.Core.CMS.Service
{
    public abstract class BaseItemCmsIntegrator<X, Y> : IItemCmsIntegrator where X : BaseDbEntity where Y : BaseCmsViewModel
    {
        public ISqlReadonlyRepository<X> SqlReadonlyRepository { get; private set; }
        public ICmsRepository<Y> CmsRepository { get; private set; }
        public ICmsTranslator<X, Y> Translator { get; private set; }
        public List<AppChannel> Channels { get; private set; }

        public BaseItemCmsIntegrator(
            ISqlReadonlyRepository<X> sqlReadonlyRepository,
            ICmsRepository<Y> cmsRepository,
            ICmsTranslator<X, Y> translator,
            params AppChannel[] channels)
        {
            SqlReadonlyRepository = sqlReadonlyRepository;
            CmsRepository = cmsRepository;
            Translator = translator;
            Channels = channels.ToList();
        }

        public virtual void Integrate()
        {
            var allSql = GetItemsToIntegrate();
            var allCms = CmsRepository.GetAll();

            var listToAdd = SelectRecordsToAdd(allSql, allCms);
            var listToUpd = SelectRecordsToUpdate(allSql, allCms);
            var listToDel = SelectRecordsToDelete(allSql, allCms);

            /*
            foreach (var item in listToAdd)
            {
                CmsRepository.Insert(item);
            }

            foreach (var item in listToUpd)
            {
                CmsRepository.Update(item);
            }

            foreach (var item in listToDel)
            {
                CmsRepository.Delete(item.Id);
            }
            */
        }

        public virtual IEnumerable<X> GetItemsToIntegrate()
        {
            return SqlReadonlyRepository.GetAll();
        }

        protected virtual IEnumerable<Y> SelectRecordsToAdd(IEnumerable<X> allSql, IEnumerable<Y> allCms)
        {
            var allSqlToAdd = allSql.Where(a => !allCms.Select(b => b.IdElos).Contains(a.Id));
            return Translator.Translate(allSqlToAdd);
        }

        protected virtual IEnumerable<Y> SelectRecordsToUpdate(IEnumerable<X> allSql, IEnumerable<Y> allCms)
        {
            var allSqlToUpt = allSql.Where(a => allCms.Select(b => b.IdElos).Contains(a.Id));
            return Translator.Translate(allSqlToUpt);
        }

        protected virtual IEnumerable<Y> SelectRecordsToDelete(IEnumerable<X> allSql, IEnumerable<Y> allCms)
        {
            var allCmsToDel = allCms.Where(a => !allSql.Select(b => b.Id).Contains(a.IdElos)).ToList();
            return allCmsToDel;
        }
    }
}