using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
namespace _1.DAL.Models
{
    public class BanGiayDBContext : DbContext
    {
        public BanGiayDBContext()
        {

        }
        public BanGiayDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=ANTHONYPC\\SQLEXPRESS;Initial Catalog=Duan1;" +
                "Persist Security Info=True;User ID=Linh;Password=123"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
