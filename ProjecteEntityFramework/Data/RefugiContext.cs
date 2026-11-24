using Microsoft.EntityFrameworkCore;
using ProjecteEntityFramework.Models;

namespace ProjecteEntityFramework.Data;

public class RefugiContext : DbContext
{
    
    public RefugiContext( ) {}
    
    public DbSet<Animal>  Animals { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlite("Data Source=RefugiAnimals.db");
        optionsBuilder.UseLazyLoadingProxies();
    }
    
    // 3 · Fluent API: les relacions                              // NOU: tot aquest mètode
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>()
            .HasOne(a => a.Xip)
            .WithOne(x => x.Animal)
            .HasForeignKey<Xip>(x => x.AnimalID);
        modelBuilder.Entity<Xip>()
            .HasIndex(x => x.Codi)
            .IsUnique();
    }
    
}