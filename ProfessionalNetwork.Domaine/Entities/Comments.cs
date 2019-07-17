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
        public int Id_Com { get; set; }

        public long FK_jobseeker { get; set; }
        public Jobseeker Jobseeker { get; set; }

        public long FK_Post { get; set; }
        public Posts Posts { get; set; }

        public string Comment { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date_Com { get; set; }
    }
}
