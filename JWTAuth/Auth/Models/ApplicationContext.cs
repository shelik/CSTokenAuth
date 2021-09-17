using Microsoft.EntityFrameworkCore;
using System;
 
namespace Auth.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            // Console.WriteLine("Rere");
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlite("Data Source=DBFileName.db");
    }
}