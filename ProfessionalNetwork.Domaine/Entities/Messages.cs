using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Messages
    {
        [Key, Column(Order = 0)]
        public long Id_Entrepirse { get; set; }

        [Key, Column(Order = 1)]
        public long id_jobseeker { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date_message { get; set; }
        public string Content { get; set; }
        public string sender { get; set; }

        [ForeignKey("id_jobseeker")]
        public Jobseeker Jobseekers { get; set; }
        [ForeignKey("Id_Entrepirse")]
        public Entreprise_admin Entreprise_admins { get; set; }



    }
}
