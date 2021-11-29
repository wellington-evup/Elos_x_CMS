using System;

namespace Elos_x_CMS.Core.CMS.ViewModel
{
    public abstract class BaseCmsViewModel
    {
        public Guid Id { get; set; }
        public long IdElos { get; set; }
    }
}