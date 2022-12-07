using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class RolesController
    {
        internal List<Role>? getAllRoles() => DatabaseService.getAllRoles()?.ToList();

        internal long getRoleIdByName(string roleName)
        {
            try
            {
                return DatabaseService.getRoleIdByName(roleName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
    }
}
