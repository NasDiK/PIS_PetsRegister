using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApplication.Models.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? FullName { get; set; }
        public Role? Role { get; set; } = new Role() { Id = -1, Name = "Guest" }; //Тут разве не ID?
        public string? PhoneNumber { get; set; }
    }
}
