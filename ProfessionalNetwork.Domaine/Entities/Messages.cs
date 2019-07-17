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

        [Key]
        public int Id_Msg { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_message { get; set; }
        public string Content { get; set; }
        public string sender { get; set; }


        public long id_jobseeker { get; set; }
        public Jobseeker Jobseekers { get; set; }
        public long Id_Entrepirse { get; set; }
        public Entreprise_admin Entreprise_admins { get; set; }



    }
}
