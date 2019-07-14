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
            HasKey(a => new {a.id_jobseeker, a.Id_Post});


        }
    }
}
