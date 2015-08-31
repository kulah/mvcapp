using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcApp.Models.Mapping
{
    public class TAN_KURUMMap : EntityTypeConfiguration<TAN_KURUM>
    {
        public TAN_KURUMMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.K_KODU)
                .HasMaxLength(50);

            this.Property(t => t.K_ADI)
                .HasMaxLength(50);

            this.Property(t => t.K_YETKILI_1)
                .HasMaxLength(50);

            this.Property(t => t.K_YETKILI_2)
                .HasMaxLength(50);

            this.Property(t => t.K_IL)
                .HasMaxLength(50);

            this.Property(t => t.K_ILCE)
                .HasMaxLength(50);

            this.Property(t => t.K_TIP)
                .HasMaxLength(50);

            this.Property(t => t.K_SEKTOR)
                .HasMaxLength(50);

            this.Property(t => t.K_ADRES)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("TAN_KURUM");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.K_KODU).HasColumnName("K_KODU");
            this.Property(t => t.K_ADI).HasColumnName("K_ADI");
            this.Property(t => t.K_YETKILI_1).HasColumnName("K_YETKILI_1");
            this.Property(t => t.K_YETKILI_2).HasColumnName("K_YETKILI_2");
            this.Property(t => t.K_IL).HasColumnName("K_IL");
            this.Property(t => t.K_ILCE).HasColumnName("K_ILCE");
            this.Property(t => t.K_TIP).HasColumnName("K_TIP");
            this.Property(t => t.K_SEKTOR).HasColumnName("K_SEKTOR");
            this.Property(t => t.K_ADRES).HasColumnName("K_ADRES");
        }
    }
}
