using Microsoft.EntityFrameworkCore;
using ThreeTierApplication.Model;
using ThreeTierApplication.Model.Entities;

namespace ThreeTierApplication.Database;

public class AppDb : DbContext
{
    public AppDb(DbContextOptions<AppDb> options) : base(options)
    {
    }

    public DbSet<Human> Humans { get; set; }
}