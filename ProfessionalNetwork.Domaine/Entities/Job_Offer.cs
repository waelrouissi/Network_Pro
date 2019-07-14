using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public  class Job_Offer : EntityTrace
    {
        [Key]
        public long Id_JobOffer { get; set; }
        public string job_title { get; set; }
        public string Job_Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Offer { get; set; }
        public int Nbr_Candidat { get; set; }
        public DateTime Date_Expiration { get; set; }
        public bool visibility { get; set; }
        
        public long EntrepirseFK { get; set; }
        public Entreprise_admin Entreprise_Admin { get; set; }


        public ICollection<Application> Applications { get; set; }
         
        //public long Project_ManagerFK { get; set; }
        //public Project_Manager Project_Manager { get; set;  }
    }
}
