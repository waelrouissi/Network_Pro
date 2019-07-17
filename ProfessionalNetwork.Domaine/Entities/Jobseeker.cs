using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Jobseeker: Account
    {
        [Key]
        public long id_jobseeker { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Intro_jobseeker { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_of_birth { get; set; }
        public string Certif { get; set; }
        public string Skills { get; set; }


        public ICollection<Application> Applications { get; set; }
        public ICollection<Posts> Posts { get; set; }
        public ICollection<Likes> Likes { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}
