namespace egzamin.Models
{
    public class TaskType
    {
        public TaskType()
        {
            Tasks = new HashSet<Task>();
        }

        public int IdTaskType { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}