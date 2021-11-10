using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamalıM.Entities;

namespace UygulamalıM.DataAccess
{
    class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("host=localhost;database=UygulamalıM;user id=postgres;password=123456;");

        }

        public DbSet<Account> Accounts { get; set; }
    }
}
