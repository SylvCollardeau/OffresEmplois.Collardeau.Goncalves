using Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.FluentEntities
{
    public class FormationFluent : EntityTypeConfiguration<Formation>
    {
            public FormationFluent(){
                ToTable("Formation");
                HasKey(form => form.Id);

                Property(form => form.Id).HasColumnName("FORM_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                Property(form => form.Date).HasColumnName("FORM_DATE").IsRequired();
                Property(form => form.Title).HasColumnName("FORM_TITLE").IsRequired();
        }
    }
}
