using Core.Entities;

namespace Entities.Entities
{
    public class BlogUser: BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
