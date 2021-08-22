using System;
using System.Collections.Generic;
using UserDataBaseBLL.ModelsBLL;
using UserDataBaseDAL.Models;

namespace UserDataBaseBLL.Mapping
{
    public static class MapperProfileUser
    {
        public static User MapToDALUser(this UserBLL userBL)
        {
            var userDAL = new User
            {
                Id = userBL.Id,
                Name = userBL.Name,
                Surname = userBL.Surname,
                Details = new Details 
                {
                    Adress = userBL.Details.Adress,
                    Age = userBL.Details.Age
                }
            };

            return userDAL;
        }

        public static UserBLL MapToBLLUser(this User userDAL)
        {
            var userBLL = new UserBLL
            {
                Id = userDAL.Id,
                Name = userDAL.Name,
                Surname = userDAL.Surname,
                Details = new DetailsBLL
                {
                    Adress = userDAL.Details.Adress,
                    Age = userDAL.Details.Age
                }
            };

            return userBLL;
        }

        public static IEnumerable<UserBLL> MapToEnumerableUserBLL(this IEnumerable<User> users)
        {
            foreach(var t in users)
            {
                yield return t.MapToBLLUser();
            }
        }

        public static IEnumerable<User> MapToEnumerableUserBLL(this IEnumerable<UserBLL> users)
        {
            foreach (var t in users)
            {
                yield return t.MapToDALUser();
            }
        }
    }
}
