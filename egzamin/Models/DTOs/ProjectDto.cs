namespace egzamin.Models.DTOs
{
    public class ProjectDto
    {
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public IEnumerable<TaskDto> Tasks { get; set; }



    }
}
