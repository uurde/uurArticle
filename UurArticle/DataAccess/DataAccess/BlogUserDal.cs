using Core.DataAccess;
using DataAccess.Abstracts;
using Entities.Entities;

namespace DataAccess.DataAccess
{
    public class BlogUserDal : EntityRepository<BlogUser, Context>, IBlogUserDal
    {
    }
}
