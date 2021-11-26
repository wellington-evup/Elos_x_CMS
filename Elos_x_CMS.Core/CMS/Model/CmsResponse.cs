using System.Collections.Generic;

namespace Elos_x_CMS.Core.CMS.Model
{
    public class CmsResponse<T>
    {
        public int total { get; set; }
        public List<CmsRecord<T>> items { get; set; }
    }
}
