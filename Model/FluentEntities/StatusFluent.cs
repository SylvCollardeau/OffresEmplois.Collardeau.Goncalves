using Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Model.FluentEntities
{
    public class StatusFluent : EntityTypeConfiguration<Status>
    {
        public StatusFluent() {
            ToTable("Status");
            HasKey(sta => sta.Id);

            Property(sta => sta.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(sta => sta.Label).HasColumnName("STA_LABEL").IsRequired();
        }
    }
}
