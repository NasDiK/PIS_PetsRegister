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
        DatabaseController dbController;

        internal AuthController(DatabaseController dbController)
        {
            this.dbController = dbController;
        }

        internal User? AuthUser(string username, string password)
        {
            var user = dbController.getUserByLogin(username);
            if (user != null && user.Password == password)
                return user;
            else
                return null;
        }

        internal User? RegisterUser(string username, string password, string phone, string fullname, long roleId)
        {
            var userByLogin = dbController.getUserByLogin(username);
            var userByPhone = dbController.getUserByLogin(phone);

            if (userByLogin != null || userByPhone != null)
                return null;
            else
                return dbController.RegisterUser(new User() { 
                    FullName = fullname,
                    Password = password,
                    Username = username,
                    PhoneNumber = phone,
                    RoleId = roleId }
                );
        }
    }
}
