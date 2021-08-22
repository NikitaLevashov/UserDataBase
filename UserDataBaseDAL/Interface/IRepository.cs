using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataBaseDAL.Models;

namespace UserDataBaseDAL.Interface
{
    public interface IRepository
    {
        IEnumerable<User> Get();
        void Delete(User item);
        void Add(User item);
    }
}
