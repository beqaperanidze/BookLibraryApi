using Microsoft.EntityFrameworkCore;

namespace WebApplication;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
}