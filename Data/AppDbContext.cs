using CinemaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaMVC.Data;

public class AppDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}