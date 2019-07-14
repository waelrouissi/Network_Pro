using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class ApplicationConfiguration: EntityTypeConfiguration<Application>
    {
        //HasRequired<Bibliotheque>(s => s.Bibliotheque)
        //        .WithMany(t => t.Documents).
        //        .HasForeignKey(u => u.BibliothequeFK)
        //        .WillCascadeOnDelete(true);

       
               public  ApplicationConfiguration()
               {

                this.ToTable("Application");
                HasKey<long>(a => a.Id_Application);
                //one to many relation
                HasRequired<Jobseeker>(t => t.Jobseeker).WithMany(t => t.Applications).HasForeignKey(t => t.Job_SeekerFK).WillCascadeOnDelete(true);

                HasRequired<Job_Offer>(t => t.Job_Offer).WithMany(t => t.Applications).HasForeignKey(t => t.Job_OfferFK).WillCascadeOnDelete(true);

            }





    }
}
