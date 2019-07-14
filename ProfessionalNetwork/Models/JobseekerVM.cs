using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public class JobseekerVM: AccountVM
    {
        public long id_jobseeker { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Intro_jobseeker { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_of_birth { get; set; }
        public string Certif { get; set; }
        public string Skills { get; set; }

        public String FullName { get; set; }
        public ICollection<ApplicationVM> Applications { get; set; }
    }
}
