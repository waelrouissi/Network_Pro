using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models
{
    public class QuestionVM : EntityTrace
    {

        public long Id_Question { get; set; }
        public string Content_Question { get; set; }
        public int Correct_AnswerID{ get; set; }
        public int Point_Question { get; set; }
        public int Rank { get; set; }

        public string choice1 { get; set; }
        public string choice2 { get; set; }
        public string choice3 { get; set; }

        public long TestFK { get; set; }
        public TestVM Test { get; set; }
    }
}
