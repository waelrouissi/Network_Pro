using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class JobSeekerConfiguration: EntityTypeConfiguration<Jobseeker>
    {
        //HasRequired<Bibliotheque>(s => s.Bibliotheque)
        //        .WithMany(t => t.Documents).
        //        .HasForeignKey(u => u.BibliothequeFK)
        //        .WillCascadeOnDelete(true);
               public JobSeekerConfiguration()
               {

                    this.ToTable("Job_Seeker");
                    HasKey<long>(a => a.id_jobseeker);
                    //one to many relation
                }
    }
}
