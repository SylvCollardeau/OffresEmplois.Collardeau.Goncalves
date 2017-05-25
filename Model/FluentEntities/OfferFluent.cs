using Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Model.FluentEntities
{
    public class OfferFluent : EntityTypeConfiguration<Offer>
    {
        public OfferFluent()
        {
            ToTable("Offer");
            HasKey(off => off.Id);

            Property(off => off.Id).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(off => off.Title).HasColumnName("OFF_TITLE").IsRequired();
            Property(off => off.Date).HasColumnName("OFF_DATE").IsRequired();
            Property(off => off.Salary).HasColumnName("OFF_SALARY").IsRequired();
            Property(off => off.Description).HasColumnName("OFF_DESCRIPTION").IsRequired();
            Property(off => off.Responsible).HasColumnName("OFF_RESPONSIBLE").IsRequired();
            Property(off => off.StatusId).HasColumnName("STA_ID").IsRequired();


            HasRequired(off => off.Status).WithMany(sta => sta.Offers).HasForeignKey(sta => sta.StatusId);
        }
    }
}
