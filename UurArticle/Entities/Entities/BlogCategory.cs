using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Entities
{
    public class BlogCategory : BaseEntity, IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
