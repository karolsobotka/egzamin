using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using egzamin.Models;

namespace egzamin.Configuration
{

    public class TasksConfiguration : IEntityTypeConfiguration<Models.Task>
    {
        public void Configure(EntityTypeBuilder<Models.Task> builder)
        {
            builder.HasKey(e => e.IdTask).HasName("Task_Id");
            builder.Property(e => e.IdTask).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Deadline);
            builder.Property(e => e.IdTeam);
            builder.Property(e => e.IdTaskType);
            builder.Property(e => e.IdCreator);


            //var Tasks = new List<Models.Task>();

            //Tasks.Add(new Models.Task
            //{
            //    IdTask = 1,
            //    Name = "projekt 1",
            //    Description = "opis projektu 1",
            //    Deadline = DateTime.Now.AddDays(10),
            //    IdTeam = 1,
            //    IdTaskType = 1,
            //    IdAssignedTo = 1,
            //    IdCreator = 1

            //});
            //Tasks.Add(new Models.Task
            //{
            //    IdTask = 2,
            //    Name = "projekt 2",
            //    Description = "opis projektu 2",
            //    Deadline = DateTime.Now.AddDays(10),
            //    IdTeam = 2,
            //    IdTaskType = 2,
            //    IdAssignedTo = 2,
            //    IdCreator = 2

            //});
            //Tasks.Add(new Models.Task
            //{
            //    IdTask =3,
            //    Name = "projekt 3",
            //    Description = "opis projektu 3",
            //    Deadline = DateTime.Now.AddDays(10),
            //    IdTeam = 3,
            //    IdTaskType = 3,
            //    IdAssignedTo = 3,
            //    IdCreator = 3

            //});

//builder.HasData(Tasks);


        }
    }
}
