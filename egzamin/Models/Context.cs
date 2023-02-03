using egzamin.Configuration;
using Microsoft.EntityFrameworkCore;

namespace egzamin.Models
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }   

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskType> TaskTypes { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("s20439");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectsConfiguration());
            modelBuilder.ApplyConfiguration(new TasksConfiguration());
            modelBuilder.ApplyConfiguration(new TaskTypesConfiguration());
            modelBuilder.ApplyConfiguration(new TeamMemberConfiguration());
        }

    }
}
