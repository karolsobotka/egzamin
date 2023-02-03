using egzamin.Models;
using egzamin.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace egzamin.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public readonly Context context;

        public ProjectRepository(Context context)
        {
            this.context = context;
        }
        public async Task<string> AddTaskAsync(TaskDto task)
        {
            
                await context.AddAsync(new Models.Task
                {
                    Name = task.Name,
                    Description = task.Description,
                    Deadline = task.Deadline,


                });
                await context.SaveChangesAsync();
            
           
            return "Success!";

        }

        public async Task<ProjectDto> GetProjectAsync(int id)
        {
            var wantedProject = await context.Projects.FindAsync(id);

            if (wantedProject == null)
                return null;

            ProjectDto project = await context
                .Projects
                .Where(e => e.IdTeam == id)
                .Select(e => new ProjectDto
                {   
                    IdTeam = e.IdTeam,
                    Name=e.Name,
                    Tasks = e.Tasks.Select(e => new TaskDto
                    {
                        Name = e.Name,
                        Description =e.Description,
                        Deadline =e.Deadline,
                        TaskType = e.taskType.Name,
                    })

                }).FirstAsync();
            return project;
        }
    }
}
