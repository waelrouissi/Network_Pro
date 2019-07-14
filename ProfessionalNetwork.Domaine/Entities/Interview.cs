using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Interview : EntityTrace
    {
        [Key]
        public long Id_Interview { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date_Interview { get; set; }

        public Enum_Type_Interview Type_Interview { get; set; }

        public State_Application State_interview { get; set; }


        public long TestFK { get; set; }
        public Test Test { get; set; }

        public long Applciation_FK { get; set; }
        public Application Application { get; set; }


    }
}
