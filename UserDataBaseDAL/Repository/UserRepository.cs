using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataBaseDAL.EFCore;
using UserDataBaseDAL.Interface;
using UserDataBaseDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace UserDataBaseDAL.Repository
{
    public class UserRepository : IRepository
    {
        UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public IEnumerable<User> Get()
        {
            return _context.Users.AsNoTracking().Include(x=>x.Details);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
             var t =  _context.Users.AsNoTracking();
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
