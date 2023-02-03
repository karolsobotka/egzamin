using egzamin.Models.DTOs;

namespace egzamin.Repositories
{
    public interface IProjectRepository 
    {
        Task<ProjectDto> GetProjectAsync(int id);
        Task<string> AddTaskAsync(TaskDto task);

    }
}
