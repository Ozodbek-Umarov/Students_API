using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructures;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<Student> Students { get; set; }
}
