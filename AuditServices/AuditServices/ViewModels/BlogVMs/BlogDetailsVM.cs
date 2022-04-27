using AuditServices.Models.Entities;
using AuditServices.ViewModels.CommentVMs;

namespace AuditServices.ViewModels.BlogVMs
{
    public class BlogDetailsVM
    {
        public Blog Blog { get; set; }
        public string Image { get; set; }
        public CommentCreateVM CommentCreateVM { get; set; }
    }
}
