using Entities.Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryBusiness
    {
        BlogCategory Get(int categoryId);
        List<BlogCategory> GetAll();
        void Insert(BlogCategory category);
        void Update(BlogCategory category);
        void Delete(BlogCategory category);
        void MarkAsDeleted(int categoryId);
    }
}
