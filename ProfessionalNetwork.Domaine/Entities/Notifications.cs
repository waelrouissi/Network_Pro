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
             
        [Key]
        public int Id_notif { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Notif { get; set; }
        public string Type { get; set; }
        public long Id_JobOffer { get; set; }
        public Job_Offer Job_Offers { get; set; }
        public long id_jobseeker { get; set; }
        public Jobseeker Jobseeker { get; set; }
    }
}
