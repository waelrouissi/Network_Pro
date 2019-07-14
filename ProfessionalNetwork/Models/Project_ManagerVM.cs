using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public class Project_ManagerVM : AccountVM
    {
        public long Id_Project_Manager { get; set; }
        public ICollection<Job_OfferVM> Job_Offers { get; set; }
    }
}
