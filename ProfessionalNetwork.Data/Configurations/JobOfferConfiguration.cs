using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class JobOfferConfiguration: EntityTypeConfiguration<Job_Offer>
    {
        
               public JobOfferConfiguration()
               {

                    this.ToTable("Job_Offer");
                    HasKey<long>(a => a.Id_JobOffer);
            //one to many relation
            HasRequired<Entreprise_admin>(t => t.Entreprise_Admin).WithMany(t => t.Job_Offers).
                        HasForeignKey(t => t.EntrepirseFK).WillCascadeOnDelete(true);
                }
    }
}
