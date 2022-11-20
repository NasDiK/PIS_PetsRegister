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
            var user = DatabaseController.getUserByLogin(username);
            if (user.Password == password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
