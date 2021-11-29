using Elos_x_CMS.Core.Enum;

namespace Elos_x_CMS.Core.Entity
{
    public class AppChannel : BaseDbEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public EAppChannelType Type { get; set; }
    }
}
