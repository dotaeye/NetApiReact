using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using NetApiReact.Data.Models;

namespace NetApiReact.Data.Mapping
{
    public partial class UserActivitiesMap : EntityTypeConfiguration<UserActivities>
    {
        public UserActivitiesMap()
        {
            this.HasKey(a => a.Id);

            this.Property(x => x.Type);

            this.HasRequired(a => a.User).WithMany(x => x.UserActivities)

                .HasForeignKey(x => x.UserId).WillCascadeOnDelete(false);
        }
    }
}
