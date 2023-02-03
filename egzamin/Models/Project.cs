namespace egzamin.Models
{
    public class Project
    {
        public Project()
        {
            Tasks = new HashSet<Task>();

        }
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }

        public int MyProperty { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

    }
}