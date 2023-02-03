using egzamin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace egzamin.Configuration
{
    public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasKey(e => e.IdTeamMember).HasName("TeamMember_Id");
            builder.Property(e => e.IdTeamMember).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();



            var TeamMembers = new List<TeamMember>();
            TeamMembers.Add(new TeamMember
            {
                IdTeamMember = 1,
                FirstName = "TeamMember FName 1",
                LastName = "TeamMember LName 1",
                Email = "TeamMemberEmail2@email.com"
            });
            TeamMembers.Add(new TeamMember
            {
                IdTeamMember = 2,
                FirstName = "TeamMember FName 2",
                LastName = "TeamMember LName 2",
                Email = "TeamMemberEmail2@email.com"

            });
            TeamMembers.Add(new TeamMember
            {
                IdTeamMember = 3,
                FirstName = "TeamMember FName 3",
                LastName = "TeamMember LName 3",
                Email = "TeamMemberEmail3@email.com"

            });


        }
    }
}
