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
            optionsBuilder.UseSqlServer(@"Data Source=78.152.169.137;Initial Catalog = CarIdDb;Integrated Security = False;User ID = sa;Password = 5e9d11a14ad1c8dd77e98ef9b53fd1ba_Aa;Connect Timeout = 30;Encrypt = False;TrustServerCertificate = True;ApplicationIntent = ReadWrite;MultiSubnetFailover = False;");
        }

        public DbSet<CarInfo> Posts { get; set; }
    }
}
