using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataBase
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"DataSource={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.id).ValueGeneratedOnAdd();
            var user = new DatabaseUser()
            {
                id = 1,
                Name = "john doe",
                Password = "1234",
                Role = Welcome.Others.UserRolesEnum.ADMIN,
                expires = DateTime.Now.AddYears(10)
            };
        }
        public DbSet<DatabaseUser> Users { get; set; }
        
    }
    
}
