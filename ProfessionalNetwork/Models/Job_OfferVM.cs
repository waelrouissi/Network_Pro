using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public  class Job_OfferVM : EntityTrace
    {
        public long Id_JobOffer { get; set; }
        public string job_title { get; set; }
        public string Job_Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Offer { get; set; }
        public int Nbr_Candidat { get; set; }
        public DateTime Date_Expiration { get; set; }
        public bool visibility { get; set; }
        
        public long EntrepirseFK { get; set; }
        public Entreprise_adminVM Entreprise_Admin { get; set; }


        public ICollection<ApplicationVM> Applications { get; set; }

      //  public int Id_Project_Manager { get; set; }
        //public Project_ManagerVM Project_Manager { get; set; }
    }
}
