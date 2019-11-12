using Entities.Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserBusiness
    {
        BlogUser Get(int userId);
        List<BlogUser> GetAll();
        void Insert(BlogUser user);
        void Update(BlogUser user);
        void Delete(BlogUser user);
        void MarkAsDeleted(int userId);
    }
}
