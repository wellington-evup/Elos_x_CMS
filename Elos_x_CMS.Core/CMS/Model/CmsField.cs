namespace Elos_x_CMS.Core.CMS.Model
{
    public class CmsField<T>
    {
        public CmsField(T value)
        {
            iv = value;
        }
        public T iv { get; set; }
    }
}
