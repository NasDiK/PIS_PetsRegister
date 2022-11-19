using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Controllers
{
    internal class AuthController
    {
        internal static User? AuthUser(string username, string password)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
                return user;
            }
        }
    }
}
