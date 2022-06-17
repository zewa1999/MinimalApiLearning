using Microsoft.EntityFrameworkCore;
using MinimalApiLearning.Models;

namespace MinimalApiLearning.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
    {
    }

    public DbSet<Command> Commands => Set<Command>();
}
