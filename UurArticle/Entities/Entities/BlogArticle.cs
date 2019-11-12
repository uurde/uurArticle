using Core.Entities;

namespace Entities.Entities
{
    public class BlogArticle : BaseEntity, IEntity
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
    }
}
