using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataBaseDAL.Models;

namespace UserDataBaseDAL.EFCore
{
    public class InitialData
    {
        public static void Initial(UserContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            User user1 = new User { Name = "Misha", Surname = "Mironov" };
            User user2 = new User { Name = "Pavel", Surname = "Kironov" };
            User user3 = new User { Name = "Egor", Surname = "Lopenov" };
            User user4 = new User { Name = "Nikita", Surname = "Volodko" };
            User user5 = new User { Name = "Danya", Surname = "Filonov" };
            User user6 = new User { Name = "Stas", Surname = "Xilonov" };
            User user7 = new User { Name = "Aleksandr", Surname = "Lovosox" };
            User user8 = new User { Name = "Mitya", Surname = "Akonov" };
            User user9 = new User { Name = "Ilya", Surname = "Bonov" };
            User user10 = new User { Name = "Yura", Surname = "Ronin" };

            db.Users.AddRange(user1, user2, user3, user4, user5, user6, user7, user8, user9, user10);

            Details detail1 = new Details { Age = 21, Adress = "Minsk", User = user1 };
            Details detail2 = new Details { Age = 24, Adress = "Gomel", User = user2 };
            Details detail3 = new Details { Age = 31, Adress = "Gomel", User = user3 };
            Details detail4 = new Details { Age = 34, Adress = "Grodno", User = user4 };
            Details detail5 = new Details { Age = 41, Adress = "Grodno", User = user5 };
            Details detail6 = new Details { Age = 34, Adress = "Vitebsk", User = user6 };
            Details detail7 = new Details { Age = 76, Adress = "Moscow", User = user7 };
            Details detail8 = new Details { Age = 12, Adress = "Kiev", User = user8 };
            Details detail9 = new Details { Age = 35, Adress = "Brest", User = user9 };
            Details detail10 = new Details { Age = 26, Adress = "Vilnus", User = user10 };

            db.Details.AddRange(detail1, detail2, detail3, detail4, detail5, detail6, detail7, detail8, detail9, detail10);

            db.SaveChanges();
        }
    }
}
