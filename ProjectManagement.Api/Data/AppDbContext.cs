using Microsoft.EntityFrameworkCore;

namespace ProjectManagement.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}