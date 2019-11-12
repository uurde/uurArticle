using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private IBlogCategoryDal _categoryDal;

        public CategoryBusiness(IBlogCategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public BlogCategory Get(int categoryId)
        {
            return _categoryDal.Get(x => x.CategoryId == categoryId);
        }

        public List<BlogCategory> GetAll()
        {
            return _categoryDal.GetList().Where(x => x.IsDeleted == false).OrderBy(x => x.CategoryName).ToList();
        }

        public void Insert(BlogCategory category)
        {
            _categoryDal.Insert(category);
        }

        public void Update(BlogCategory category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(BlogCategory category)
        {
            _categoryDal.Delete(category);
        }

        public void MarkAsDeleted(int categoryId)
        {
            var category = _categoryDal.Get(x => x.CategoryId == categoryId);
            category.IsDeleted = true;
            _categoryDal.Update(category);
        }
    }
}
