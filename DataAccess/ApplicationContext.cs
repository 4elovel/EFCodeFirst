using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Team> Teams { get; set; } = null!;
    public DbSet<Player> Players { get; set; } = null!;
    public DbSet<Match> Matches { get; set; } = null!;
    public DbSet<Goal> Goals { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Data.db");
    }
}