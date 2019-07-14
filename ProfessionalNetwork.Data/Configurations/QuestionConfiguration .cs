using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class QuestionConfiguration: EntityTypeConfiguration<Question>
    {
        //HasRequired<Bibliotheque>(s => s.Bibliotheque)
        //        .WithMany(t => t.Documents).
        //        .HasForeignKey(u => u.BibliothequeFK)
        //        .WillCascadeOnDelete(true);

       
               public  QuestionConfiguration()
               {

                    this.ToTable("Question");
            HasKey<long>(a => a.Id_Question);
            //one to many relation
            HasRequired<Test>(t => t.Test).WithMany(t => t.Questions).HasForeignKey(t => t.TestFK).WillCascadeOnDelete(true);

                }


    }
}
