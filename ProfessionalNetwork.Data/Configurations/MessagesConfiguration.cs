using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class MessagesConfiguration : EntityTypeConfiguration<Messages>
    {
        public MessagesConfiguration ()
        {
            HasKey(a => new { a.id_jobseeker, a.Entreprise_admins });

        }
    }
}
