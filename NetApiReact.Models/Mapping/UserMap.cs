using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using NetApiReact.Data.Models;

namespace NetApiReact.Data.Mapping
{
    public partial class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(a => a.Id);

            this.Property(x => x.UserName).IsRequired().HasMaxLength(50);

            this.Property(x => x.Password).IsRequired().HasMaxLength(50);

            this.Property(x => x.Email).IsRequired().HasMaxLength(50);

            this.Property(x => x.Avatar).HasMaxLength(250);

            this.Property(x => x.Phone).IsRequired().HasMaxLength(50);
        }
    }
}
