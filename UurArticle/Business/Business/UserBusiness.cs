using Business.Abstract;
using DataAccess.Abstracts;
using Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Business.Business
{
    public class UserBusiness : IUserBusiness
    {
        private IBlogUserDal _userDal;

        public UserBusiness(IBlogUserDal userDal)
        {
            _userDal = userDal;
        }

        public BlogUser Get(int userId)
        {
            return _userDal.Get(x => x.UserId == userId);
        }

        public List<BlogUser> GetAll()
        {
            return _userDal.GetList().Where(x => x.IsDeleted == false).OrderBy(x => x.UserName).ToList();
        }

        public void Insert(BlogUser user)
        {
            _userDal.Insert(user);
        }

        public void Update(BlogUser user)
        {
            _userDal.Update(user);
        }

        public void Delete(BlogUser user)
        {
            _userDal.Delete(user);
        }

        public void MarkAsDeleted(int userId)
        {
            var user = _userDal.Get(x => x.UserId == userId);
            user.IsDeleted = true;
            _userDal.Update(user);
        }
    }
}
