using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Notifications
    {
        [Key, Column(Order = 0)]
        public long Id_JobOffer { get; set; }

        [Key, Column(Order = 1)]
        public long id_jobseeker { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Notif { get; set; }
        public string Type { get; set; }

        public Job_Offer Job_Offers { get; set; }
        public Jobseeker Jobseeker { get; set; }
    }
}
