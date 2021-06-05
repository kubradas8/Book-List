using KitList.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitList.DataAccess.Concrete.EntityFramework
{
   public class BookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookDB;Trusted_Connection=true");
        }

        public DbSet<Book> Books { get; set; }
    }
}
