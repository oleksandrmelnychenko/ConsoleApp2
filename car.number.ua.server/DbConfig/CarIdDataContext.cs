using car.id.server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car.id.server.DbConfig
{
    public class CarIdDataContext : DbContext
    {
        public CarIdDataContext(DbContextOptions<CarIdDataContext> options)
            : base(options)
        { }

        public CarIdDataContext()
            : this(new DbContextOptions<CarIdDataContext>())
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CarIdDataB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<CarInfo> Posts { get; set; }
    }
}
