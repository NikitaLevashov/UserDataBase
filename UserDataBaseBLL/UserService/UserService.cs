using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataBaseBLL.Interfaces;
using UserDataBaseBLL.Mapping;
using UserDataBaseBLL.ModelsBLL;
using UserDataBaseDAL.Interface;
using UserDataBaseDAL.Models;

namespace UserDataBaseBLL.UserService
{
    public class UserService : IUserService
    {
        IRepository _repository;
        public UserService(IRepository repository)
        {
            _repository = repository;
        }
        public void AddUser(UserBLL user)
        {
            _repository.Add(user.MapToDALUser());
        }

        public void Delete(UserBLL user)
        {
            _repository.Delete(user.MapToDALUser());
        }

        public IEnumerable<UserBLL> GetUsers()
        {
            return _repository.Get().MapToEnumerableUserBLL();
        }
    }
}
