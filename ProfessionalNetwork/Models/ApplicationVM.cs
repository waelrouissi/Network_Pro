using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public  class ApplicationVM
    {
        public long Id_Application { get; set; }

        //[Key, Column(Order = 1)]
        //public long Id_JobOffer { get; set; }
        
        //[Key, Column(Order = 2)]
        //public long id_jobseeker { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime Date_Application { get; set; }

        public State_Application State { get; set; }

        public long Job_OfferFK { get; set; }
        public Job_OfferVM Job_Offer { get; set; }

        public long Job_SeekerFK { get; set; }
        public JobseekerVM Jobseeker { get; set; }

        
        public ICollection<InterviewVM> Interviews { get; set; }
    }
}
