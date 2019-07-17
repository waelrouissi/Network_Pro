using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class LikesConfiguration : EntityTypeConfiguration<Likes>
    {
        public LikesConfiguration ()
        {
            this.ToTable("Likes");
            HasKey(a => new { a.Id_Like });
            HasRequired<Jobseeker>(t => t.Jobseeker).WithMany(t => t.Likes).
                   HasForeignKey(t => t.FK_jobseeker).WillCascadeOnDelete(true);

            HasRequired<Posts>(t => t.Posts).WithMany(t => t.Likes).
                  HasForeignKey(t => t.FK_Post).WillCascadeOnDelete(false);
        }
    }
}
