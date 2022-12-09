using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class AuthController
    {
        internal User? AuthUser(string username, string password)
        {
            var user = DatabaseService.getUserByLogin(username);
            if (user != null && user.Password == password)
                return user;
            else
                return null;
        }

        internal User? RegisterUser(string username, string password, string phone, string fullname, long roleId)
        {
            var userByLogin = DatabaseService.getUserByLogin(username);
            var userByPhone = DatabaseService.getUserByLogin(phone);

            if (userByLogin != null || userByPhone != null)
                return null;
            else
                return DatabaseService.RegisterUser(new User() { 
                    FullName = fullname,
                    Password = password,
                    Username = username,
                    PhoneNumber = phone,
                    RoleId = roleId }
                );
        }
    }
}
