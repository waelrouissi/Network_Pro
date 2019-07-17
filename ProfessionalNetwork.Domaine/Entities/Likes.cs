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
        [Key]
        public long Id_Like { get; set; }

        public long FK_jobseeker { get; set; }
        public Jobseeker Jobseeker { get; set; }

        public long FK_Post { get; set; }
        public Posts Posts { get; set; }

    }
}
