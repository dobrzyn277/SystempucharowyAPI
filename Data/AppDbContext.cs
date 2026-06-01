using Microsoft.EntityFrameworkCore;
using SystempucharowyAPI.Models;

namespace SystempucharowyAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Copy> Copies => Set<Copy>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);
        modelBuilder.Entity<Copy>().HasOne(c => c.Book).WithMany(b => b.Copies).HasForeignKey(c => c.BookId);
    }
}