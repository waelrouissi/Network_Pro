using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class Project_ManagerConfiguration: EntityTypeConfiguration<Project_Manager>
    {
        public Project_ManagerConfiguration() {

            /*  HasRequired<Entreprise_admin>(s => s.iciunecle)
                 .WithMany(t => t.Project_Managers)
                 .HasForeignKey(u => u.Entreprise_adminFK)
                 .WillCascadeOnDelete(true); */
            this.ToTable("Project_Manager");


            HasKey<long>(a => a.Id_Project_Manager);

            //one to many relation
            //HasRequired<Entreprise_admin>(t => t.Entreprise_admin).WithMany(t => t.Project_Managers)
            //    .HasForeignKey(t => t.EntrepirseFK).WillCascadeOnDelete(true);

            HasRequired<Entreprise_admin>(s => s.Entreprise_admins)
                  .WithMany(t => t.Project_Managers)
                  .HasForeignKey(u => u.Id_Entreprise_admin)
                  .WillCascadeOnDelete(true);

          //  this.ToTable("Project_Manager");


        }
    }
}
