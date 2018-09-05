using car.id.server.Models;
using Microsoft.EntityFrameworkCore;

namespace car.id.server.DbConfig {
    public class CarIdDataContext : DbContext {
        public CarIdDataContext(DbContextOptions<CarIdDataContext> options)
            : base(options) { }

        public CarIdDataContext()
            : this(new DbContextOptions<CarIdDataContext>()) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            //For remote debugging
            //optionsBuilder.UseSqlServer(@"Data Source=31.128.79.4;Initial Catalog=CarIdDb;Integrated Security=False;User ID=ef_migrator;Password=Grimm_jow92;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

            //For release publish debugging
            optionsBuilder.UseSqlServer(@"Data Source=192.168.0.13;Initial Catalog=CarIdDb;Integrated Security=False;User ID=ef_migrator;Password=Grimm_jow92;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarInfo>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo>().HasIndex(e => e.NRegNew).IsUnique(false);

            modelBuilder.Entity<CarInfo2013>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2013>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo2013>().HasIndex(e => e.NRegNew).IsUnique(false);

            modelBuilder.Entity<CarInfo2014>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2014>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo2014>().HasIndex(e => e.NRegNew).IsUnique(false);

            modelBuilder.Entity<CarInfo2015>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2015>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo2015>().HasIndex(e => e.NRegNew).IsUnique(false);

            modelBuilder.Entity<CarInfo2016>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2016>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo2016>().HasIndex(e => e.NRegNew).IsUnique(false);

            modelBuilder.Entity<CarInfo2017>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2017>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo2017>().HasIndex(e => e.NRegNew).IsUnique(false);

            modelBuilder.Entity<CarInfo2018>().Property(e => e.Person).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.RegAddrKoatuu).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.OperCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.OperName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.DReg).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.DepCode).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Dep).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Brand).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.ModelName).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.MakeYear).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Color).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Kind).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Body).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Purpose).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Fuel).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.Capacity).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.OwnWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.TotalWeight).HasMaxLength(250);
            modelBuilder.Entity<CarInfo2018>().Property(e => e.NRegNew).HasMaxLength(50);

            modelBuilder.Entity<CarInfo2018>().HasIndex(e => e.NRegNew).IsUnique(false);
        }

        public DbSet<CarInfo> Posts { get; set; }

        public DbSet<CarInfo2013> Posts2013 { get; set; }
        public DbSet<CarInfo2014> Posts2014 { get; set; }
        public DbSet<CarInfo2015> Posts2015 { get; set; }
        public DbSet<CarInfo2016> Posts2016 { get; set; }
        public DbSet<CarInfo2017> Posts2017 { get; set; }
        public DbSet<CarInfo2018> Posts2018 { get; set; }
    }
}
