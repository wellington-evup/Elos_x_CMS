using Elos_x_CMS.Core.CMS.Model;
using System;

namespace Elos_x_CMS.Core.CMS.DTO
{
    public class CmsBaseDTO
    {
        public CmsField<long> Id { get; set; }
        public CmsField<DateTime> DateIntegrationUTC { get; set; }
    }
}
