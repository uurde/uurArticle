using System.Collections.Generic;
using Core.DataAccess;
using DataAccess.Abstracts;
using Entities.ComplexTypes;
using Entities.Entities;
using System.Linq;

namespace DataAccess.DataAccess
{
    public class BlogArticleDal : EntityRepository<BlogArticle, Context>, IBlogArticleDal
    {
        public ArticleModel GetArticle(int articleId)
        {
            using (Context context = new Context())
            {
                var article = from a in context.BlogArticles
                               join c in context.BlogCategories
                               on a.CategoryId equals c.CategoryId
                               where a.ArticleId == articleId
                               select new ArticleModel
                               {
                                   ArticleId = a.ArticleId,
                                   Title = a.Title,
                                   ShortDescription = a.ShortDescription,
                                   Body = a.Body,
                                   CategoryId = a.CategoryId,
                                   CreUser = a.CreUser,
                                   CreDate = a.CreDate,
                                   ModUser = a.ModUser,
                                   ModDate = a.ModDate,
                                   IsDeleted = a.IsDeleted,
                                   CategoryName = c.CategoryName
                               };

                return article.FirstOrDefault();
            }
        }

        public List<ArticleModel> GetArticleDetails()
        {
            using(Context context = new Context())
            {
                var articles = from a in context.BlogArticles
                             join c in context.BlogCategories
                             on a.CategoryId equals c.CategoryId
                             select new ArticleModel
                             {
                                 ArticleId = a.ArticleId,
                                 Title = a.Title,
                                 ShortDescription = a.ShortDescription,
                                 Body = a.Body,
                                 CategoryId = a.CategoryId,
                                 CreUser = a.CreUser,
                                 CreDate = a.CreDate,
                                 ModUser = a.ModUser,
                                 ModDate = a.ModDate,
                                 IsDeleted = a.IsDeleted,
                                 CategoryName = c.CategoryName
                             };

                return articles.ToList();
            }
        }
    }
}
