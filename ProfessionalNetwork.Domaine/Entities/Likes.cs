using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Likes
    {
        [Key, Column(Order = 0)]
        public long id_jobseeker { get; set; }
        [Key, Column(Order = 1)]
        public int Id_Post { get; set; }

        //[ForeignKey("id_jobseeker")]
        public Jobseeker Jobseekers { get; set; }

        //[ForeignKey("Id_Post")]
        public Posts Posts { get; set; }
        
    }
}
