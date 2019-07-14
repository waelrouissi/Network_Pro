using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public  class Entreprise_adminVM : AccountVM
    {
        public long Id_Entrepirse { get; set; }
        public string Name_Entrerise { get; set; }
        [DataType(DataType.Text)]
        public string Intro_Entreprise { get; set; }
        public int NB_Employee { get; set; }
        [DefaultValue("Administrator")]
        public string Role { get; set; }


        public ICollection<Project_ManagerVM> Project_Managers { get; set; }


        public ICollection<JobseekerVM> Jobseekers { get; set; }


        public ICollection<Job_OfferVM> Job_Offers { get; set; }
    }
}
