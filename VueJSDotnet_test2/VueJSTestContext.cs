using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueJSDotnet_test2
{
    public class VueJSTestContext : DbContext
    {
        public DbSet <Text> Texts { get; set; }
        public DbSet <User> Users { get; set; }


        public VueJSTestContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CUCHL8L\\SQLEXPRESS;Database=VueJSTestDB;Trusted_Connection=True;");
        }

        
        
    }
}
