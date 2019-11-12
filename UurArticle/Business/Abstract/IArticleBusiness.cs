using Entities.ComplexTypes;
using Entities.Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IArticleBusiness
    {
        BlogArticle Get(int articleId);
        List<BlogArticle> GetAll();
        void Insert(BlogArticle article);
        void Update(BlogArticle article);
        void Delete(BlogArticle article);
        void MarkAsDeleted(int articleId);
        List<ArticleModel> GetArticles();
        ArticleModel GetArticle(int articleId);
    }
}
