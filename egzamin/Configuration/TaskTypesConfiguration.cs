using egzamin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace egzamin.Configuration
{
    public class TaskTypesConfiguration : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            builder.HasKey(e => e.IdTaskType).HasName("TaskType_Id");
            builder.Property(e => e.IdTaskType).UseIdentityColumn();
            builder.Property(e => e.Name);



            var TaskTypes = new List<TaskType>();
            TaskTypes.Add(new TaskType
            {
                IdTaskType = 1,
                Name = "projekt 1",

            });
            TaskTypes.Add(new TaskType
            {
                IdTaskType = 2,
                Name = "projekt 2",

            });
            TaskTypes.Add(new TaskType
            {
                IdTaskType = 3,
                Name = "projekt 3",

            });


        }
    }
}
