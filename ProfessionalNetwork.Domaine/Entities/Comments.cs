using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Comments

    {
        [Key, Column(Order = 0)]
        public long id_jobseeker { get; set; }
        
        [Key, Column(Order = 1)]
        public long Id_Post { get; set; }
        
        public string Comment { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Com { get; set; }

        [ForeignKey("id_jobseeker")]
        public Jobseeker Jobseekers { get; set; }
        [ForeignKey("Id_Post")]
        public Posts Posts { get; set; }
    }
}
