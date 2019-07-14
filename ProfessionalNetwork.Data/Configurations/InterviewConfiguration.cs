using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class InterviewConfiguration: EntityTypeConfiguration<Interview>
    {
        //HasRequired<Bibliotheque>(s => s.Bibliotheque)
        //        .WithMany(t => t.Documents).
        //        .HasForeignKey(u => u.BibliothequeFK)
        //        .WillCascadeOnDelete(true);

       
               public  InterviewConfiguration()
               {
                    this.ToTable("Interview");
                    HasKey<long>(a => a.Id_Interview);


                    
                    //one to many relation
                    HasRequired<Application>(t => t.Application).WithMany(t => t.Interviews).HasForeignKey(t => t.Applciation_FK).WillCascadeOnDelete(true);

                    HasRequired<Test>(a => a.Test).WithOptional(m => m.Interview);
                }


    }
}
