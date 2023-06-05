using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TermProjectEVBud.Data;
using TermProjectEVBud.Data;
using TermProjectEVBud.Data.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace TermProjectEVBud.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(
            "Server=(local);Database=EvBud;User ID=sa;Password=Aa123456;MultipleActiveResultSets=true;Trust Server Certificate = true");
    }
    
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Charger> Chargers { get; set; }
    public DbSet<ChargerCompany> ChargerCompanies { get; set; }
    public DbSet<Charging> Chargings { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Offers> Offers { get; set; }
    public DbSet<Reserve> Reserves { get; set; }

    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>().HasKey(b => b.BrandId);
        modelBuilder.Entity<Car>().HasKey(c => c.CarId);
        modelBuilder.Entity<Charger>().HasKey(c => c.ChargerId);
        modelBuilder.Entity<ChargerCompany>().HasKey(o => o.CompanyId);
        modelBuilder.Entity<Charging>().HasKey(h => h.ChargeId);
        modelBuilder.Entity<Location>().HasKey(l => l.LocationId);
        modelBuilder.Entity<Member>().HasKey(m => m.MemberId);
        modelBuilder.Entity<Model>().HasKey(y => y.ModelId);
        modelBuilder.Entity<Offers>().HasKey(r => r.OfferId);
        modelBuilder.Entity<Reserve>().HasKey(p => p.ReservationId);
        modelBuilder.Entity<Car>().HasOne(m => m.Member).WithMany(n => n.Cars).HasForeignKey(m => m.MemberId);
        modelBuilder.Entity<Car>().HasOne(m => m.Model).WithMany(n => n.Cars).HasForeignKey(m => m.ModelId);
        modelBuilder.Entity<Model>().HasOne(m => m.Brand).WithMany(n => n.Models).HasForeignKey(m => m.BrandId);
        modelBuilder.Entity<Charging>().HasOne(m => m.Charger).WithMany(n => n.Chargings).HasForeignKey(m => m.ChargerId);
        modelBuilder.Entity<Charging>().HasOne(m => m.Car).WithMany(n => n.Chargings).HasForeignKey(m => m.CarId);
        modelBuilder.Entity<Offers>().HasOne(m => m.Company).WithMany(n => n.Offers)
            .HasForeignKey(m => m.CompanyOffered);
        modelBuilder.Entity<Offers>().HasOne(m => m.Member).WithMany(n => n.Offers).HasForeignKey(m => m.MemberOffered);
        modelBuilder.Entity<Reserve>().HasOne(m => m.Member).WithMany(n => n.Reserves).HasForeignKey(m => m.MemberId);
        modelBuilder.Entity<Reserve>().HasOne(m => m.Charger).WithMany(n => n.Reserves).HasForeignKey(m => m.ChargerId);
        
      
        

        

    }
}