using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataBaseBLL.ModelsBLL;
using UserDataBaseDAL.Models;

namespace UserDataBaseBLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserBLL> GetUsers();
        void Delete(UserBLL user);
        void AddUser(UserBLL user);
    }
}
