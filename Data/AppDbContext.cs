using Microsoft.EntityFrameworkCore;
using SystempucharowyAPI.Models;

namespace SystempucharowyAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Tournament> Tournaments => Set<Tournament>();
    public DbSet<Match> Matches => Set<Match>();
    public DbSet<Bracket> Brackets => Set<Bracket>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Match>().HasOne(m => m.Player1).WithMany().HasForeignKey(m => m.Player1Id).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Match>().HasOne(m => m.Player2).WithMany().HasForeignKey(m => m.Player2Id).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Match>().HasOne(m => m.Winner).WithMany().HasForeignKey(m => m.WinnerId).OnDelete(DeleteBehavior.Restrict);
    }
}