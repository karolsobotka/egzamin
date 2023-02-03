namespace egzamin.Models
{
    public class TeamMember
    {
        public TeamMember()
        {
            Tasks = new HashSet<Task>();
        }
        public int IdTeamMember { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

    }
}
