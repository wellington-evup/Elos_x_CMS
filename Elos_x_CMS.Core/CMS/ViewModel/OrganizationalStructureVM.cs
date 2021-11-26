namespace Elos_x_CMS.Core.CMS.ViewModel
{
    public class OrganizationalStructureVM : BaseCmsViewModel
    {
        public string Description { get; set; }
        public bool IsRoot { get; set; }
        public bool IsLeaf { get; set; }
        public bool IsDomain { get; set; }
    }
}
