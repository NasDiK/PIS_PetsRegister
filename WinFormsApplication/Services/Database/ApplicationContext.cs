using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Services.Database
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Roles> roles { get;set; } //TODO написать изменяемые таблицы
        public ApplicationContext()
        {
            Database.EnsureCreated(); //Comment to work with Migrations
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite($"Data source=./services/database/database.db"); //to apply Migrations
            optionsBuilder.UseSqlite($"Data source=./../../../Services/Database/database.db"); //to use

            //Потому что запуск происходит из папки /bin/debug/net6.0/ а как фиксить  ¯\＿(ツ)＿/¯

        }
    }
}
