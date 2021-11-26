using System;

namespace Elos_x_CMS.Core.CMS.Model
{
    public class CmsRecord<T> : CmsRecord
    {
        public T data { get; set; }
    }

    public class CmsRecord
    {
        public string id { get; set; }
        public string status { get; set; }
    }
}