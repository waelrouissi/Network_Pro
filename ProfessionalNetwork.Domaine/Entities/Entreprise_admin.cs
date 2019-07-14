using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public  class Entreprise_admin : Account
    {
        [Key]
        public long Id_Entrepirse { get; set; }
        public string Name_Entrerise { get; set; }
        [DataType(DataType.Text)]
        public string Intro_Entreprise { get; set; }
        public int NB_Employee { get; set; }
        [DefaultValue("Administrator")]
        public string Role { get; set; }


        public ICollection<Project_Manager> Project_Managers { get; set; }

        //check next one ! 
       public ICollection<Jobseeker> Jobseekers { get; set; }


        public ICollection<Job_Offer> Job_Offers { get; set; }

    }
}
