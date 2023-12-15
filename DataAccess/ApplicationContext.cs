using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        //Database.EnsureCreated();
    }

    public DbSet<Team> Teams { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Data.db");
    }
}