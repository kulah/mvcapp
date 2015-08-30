using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApp.Models.Mapping
{
    public class USERLISTMap : EntityTypeConfiguration<USERLIST>
    {
        public USERLISTMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.username)
                .HasMaxLength(50);

            this.Property(t => t.password)
                .HasMaxLength(50);

            this.Property(t => t.adsoyad)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.tip)
                .HasMaxLength(50);

            this.Property(t => t.user_grup)
                .HasMaxLength(50);

            this.Property(t => t.kurum)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("USERLIST");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.adsoyad).HasColumnName("adsoyad");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.tip).HasColumnName("tip");
            this.Property(t => t.user_grup).HasColumnName("user_grup");
            this.Property(t => t.kurum).HasColumnName("kurum");
        }
    }
}
