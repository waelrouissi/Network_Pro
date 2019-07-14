using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public class TestVM : EntityTrace
    {
        public long Id_Test { get; set; }

        public int Nbr_Question { get; set; }
        public int Nbr_Point_Tolal { get; set; }
        public string Name_Test { get; set; }

        public ICollection<QuestionVM> Questions { get; set; }


        public InterviewVM Interview { get; set; }
    }
}
