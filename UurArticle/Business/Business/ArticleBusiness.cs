using Business.Abstract;
using DataAccess.Abstracts;
using Entities.ComplexTypes;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Business
{
    public class ArticleBusiness : IArticleBusiness
    {
        private IBlogArticleDal _articleDal;

        public ArticleBusiness(IBlogArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public BlogArticle Get(int articleId)
        {
            return _articleDal.Get(x => x.ArticleId == articleId);
        }

        public List<BlogArticle> GetAll()
        {
            return _articleDal.GetList().Where(x => x.IsDeleted == false).OrderBy(x => x.Title).ToList();
        }

        public void Insert(BlogArticle article)
        {
            _articleDal.Insert(article);
        }

        public void Update(BlogArticle article)
        {
            _articleDal.Update(article);
        }

        public void Delete(BlogArticle article)
        {
            _articleDal.Delete(article);
        }

        public void MarkAsDeleted(int articleId)
        {
            var article = _articleDal.Get(x => x.ArticleId == articleId);
            article.IsDeleted = true;
            _articleDal.Update(article);
        }

        public List<ArticleModel> GetArticles()
        {
            return _articleDal.GetArticleDetails().Where(x => x.IsDeleted == false).OrderBy(x => x.Title).ToList();
        }

        public ArticleModel GetArticle(int articleId)
        {
            return _articleDal.GetArticle(articleId);
        }
    }
}
