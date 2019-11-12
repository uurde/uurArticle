using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class BlogUser: BaseEntity, IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
