using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class EntrepriseConfiguration: EntityTypeConfiguration<Entreprise_admin>
    {
        //HasRequired<Bibliotheque>(s => s.Bibliotheque)
        //        .WithMany(t => t.Documents).
        //        .HasForeignKey(u => u.BibliothequeFK)
        //        .WillCascadeOnDelete(true);

       
               public  EntrepriseConfiguration()
               {

                    HasKey<long>(a => a.Id_Entrepirse);
                    this.ToTable("Entreprise_admin");

                //HasRequired<Project_Manager>(s => s.)
                //.WithMany(t => t.)
                //.HasForeignKey(u => u.Id_Entrepirse);
            HasKey<long>(a => a.Id_Entrepirse);
            this.ToTable("Entreprise_admin");

               }


    }
}
