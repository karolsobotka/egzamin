using egzamin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace egzamin.Configuration
{
    public class ProjectsConfiguration : IEntityTypeConfiguration<Project>
    {

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(e => e.IdTeam).HasName("Team_Id");
            builder.Property(e => e.IdTeam).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Deadline).HasMaxLength(100).IsRequired();



            var Projects = new List<Project>();
            Projects.Add(new Project
            {
                IdTeam = 1,
                Name = "projekt 1",
                Deadline = DateTime.Now,
             
            });
            Projects.Add(new Project
            {
                IdTeam = 2,
                Name = "projekt 2",
                Deadline = DateTime.Now,

            });
            Projects.Add(new Project
            {
                IdTeam = 3,
                Name = "projekt 3",
                Deadline = DateTime.Now,

            });
            builder.HasData(Projects);


        }
    }
}
