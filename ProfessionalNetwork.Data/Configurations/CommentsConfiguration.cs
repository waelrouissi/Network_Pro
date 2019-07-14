using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class CommentsConfiguration : EntityTypeConfiguration<Comments>
    {
        public CommentsConfiguration()
        {
            HasKey(a => new { a.id_jobseeker, a.Id_Post });
        }
    }
}
