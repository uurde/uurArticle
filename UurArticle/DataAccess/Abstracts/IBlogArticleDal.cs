using Core.DataAccess;
using Entities.ComplexTypes;
using Entities.Entities;
using System.Collections.Generic;

namespace DataAccess.Abstracts
{
    public interface IBlogArticleDal : IEntityRepository<BlogArticle>
    {
        List<ArticleModel> GetArticleDetails();

        ArticleModel GetArticle(int articleId);
    }
}
