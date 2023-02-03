namespace egzamin.Models.DTOs
{
    public class TaskDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string TaskType { get; set; }
    }
}
