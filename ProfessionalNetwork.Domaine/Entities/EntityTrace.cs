using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class EntityTrace
    {
        [DataType(DataType.DateTime)]
        public DateTime? Date_Created  { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Date_Modified { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? Date_Deleted { get; set; }

        public Boolean? IsDeleted { get; set; }
    }
}
