using Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Model.FluentEntities
{
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("Postulation");
            HasKey(post => new { post.EmployeeId, post.OfferId });

            Property(post => post.OfferId).HasColumnName("OFF_ID").IsRequired();
            Property(post => post.EmployeeId).HasColumnName("EMP_ID").IsRequired();

            HasRequired(post => post.Employee).WithMany(emp => emp.Postulations).HasForeignKey(emp => emp.EmployeeId);
            HasRequired(post => post.Offer).WithMany(off => off.Postulations).HasForeignKey(off => off.EmployeeId);
        }
    }
}
