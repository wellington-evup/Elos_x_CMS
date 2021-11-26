using Elos_x_CMS.Core.CMS.Model;
using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.Interface;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface IDtoCmsTranslator<X, Y> : ITranslator<X, CmsRecord<Y>> where X : BaseCmsViewModel
    {
    }
}
