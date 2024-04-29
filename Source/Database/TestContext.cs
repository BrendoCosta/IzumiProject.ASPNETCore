namespace Izumi.Database;

using Izumi.Model;
using Microsoft.EntityFrameworkCore;

public class TestContext: DbContext
{
    public TestContext(DbContextOptions<TestContext> options): base(options)
    {
    }
    public DbSet<Test> Tests { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Test>().HasKey(m => m.Id);
        base.OnModelCreating(builder);
    }
}