using Core.DataAccess;
using DataAccess.Abstracts;
using Entities.Entities;

namespace DataAccess.DataAccess
{
    public class BlogCategoryDal : EntityRepository<BlogCategory, Context>, IBlogCategoryDal
    {
    }
}
