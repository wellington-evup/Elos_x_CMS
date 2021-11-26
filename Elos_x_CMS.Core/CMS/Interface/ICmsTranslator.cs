using Elos_x_CMS.Core.CMS.ViewModel;
using Elos_x_CMS.Core.Interface;

namespace Elos_x_CMS.Core.CMS.Interface
{
    public interface ICmsTranslator<X, Y> : ITranslator<X, Y> where Y : BaseCmsViewModel
    {
    }
}
