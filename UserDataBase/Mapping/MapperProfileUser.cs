using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDataBaseBLL.ModelsBLL;
using UserDataBaseUI.Models;

namespace UserDataBaseUI.Mapping
{
    public static class MapperProfileUser
    {
        public static UserViewModel MapToViewUser(this UserBLL userBL)
        {
            var userView = new UserViewModel
            {
                Id = userBL.Id,
                Name = userBL.Name,
                Surname = userBL.Surname,
                Adress = userBL.Details.Adress,
                Age = userBL.Details.Age        
            };

            return userView;
        }

        public static UserBLL MapToBLLUser(this UserViewModel user)
        {
            var userBLL = new UserBLL
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Details = new DetailsBLL
                {
                    Adress = user.Adress,
                    Age = user.Age
                }
            };

            return userBLL;
        }

        public static IEnumerable<UserBLL> MapToEnumerableUserBLL(this IEnumerable<UserViewModel> users)
        {
            foreach (var t in users)
            {
                yield return t.MapToBLLUser();
            }
        }

        public static IEnumerable<UserViewModel> MapToEnumerableUserView(this IEnumerable<UserBLL> users)
        {
            foreach (var t in users)
            {
                yield return t.MapToViewUser();
            }
        }
    }
}
