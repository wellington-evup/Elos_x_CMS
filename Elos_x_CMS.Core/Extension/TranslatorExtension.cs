using Elos_x_CMS.Core.Interface;
using System.Collections.Generic;

namespace Elos_x_CMS.Core.Extension
{
    public static class TranslatorExtension
    {
        public static IEnumerable<X> Translate<X, Y>(this ITranslator<X, Y> translator, IEnumerable<Y> list)
        {
            if (list == null) return null;
            var ret = new List<X>();
            foreach (var item in list)
                ret.Add(translator.Translate(item));
            return ret;
        }

        public static IEnumerable<Y> Translate<X, Y>(this ITranslator<X, Y> translator, IEnumerable<X> list)
        {
            if (list == null) return null;
            var ret = new List<Y>();
            foreach (var item in list)
                ret.Add(translator.Translate(item));
            return ret;
        }
    }
}
