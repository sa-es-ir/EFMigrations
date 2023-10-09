using EFCoreMigrations.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrations.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; }
}
