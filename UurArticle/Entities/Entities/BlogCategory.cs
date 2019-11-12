using Core.Entities;

namespace Entities.Entities
{
    public class BlogCategory : BaseEntity, IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
