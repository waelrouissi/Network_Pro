using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class PostsConfiguration: EntityTypeConfiguration<Posts>
    {
        public PostsConfiguration()
        {
            this.ToTable("Posts");
            HasKey(a => new { a.Id_Post });
            //one to many relation
            HasRequired<Jobseeker>(t => t.Jobseeker).WithMany(t => t.Posts).
                        HasForeignKey(t => t.Job_SeekerFK).WillCascadeOnDelete(true);


            // HasRequired<Jobseeker>(t => t.Jobseeker).WithMany(t => t.Posts).HasForeignKey(t => t.Job_SeekerFK).WillCascadeOnDelete(true);
        }
    }
}
