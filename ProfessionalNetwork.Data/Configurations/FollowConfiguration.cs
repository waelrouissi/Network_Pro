using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class FollowConfiguration:EntityTypeConfiguration<Follow>
    {
        public FollowConfiguration()
        {
            //HasKey(d => new {d.AdherantId, d.DocumentId, d.Date
            HasKey(d => new { d.Id_Entrepirse, d.id_jobseeker });
        }
    }
}
