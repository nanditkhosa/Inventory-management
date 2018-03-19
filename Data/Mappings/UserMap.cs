using System.Data.Entity.ModelConfiguration;
using Core.Domains;

namespace Data.Mappings
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Table 
            ToTable("User", "dbo");
            // Primary Key
            HasKey(u => u.Id);

            // validations
            Property(c => c.EmailId)
                    .IsRequired()
                    .HasMaxLength(100);

            HasOptional(x => x.Facility)
                .WithMany()
                .HasForeignKey(x => x.FacilityId)
                .WillCascadeOnDelete(false);
        }
    }
}
