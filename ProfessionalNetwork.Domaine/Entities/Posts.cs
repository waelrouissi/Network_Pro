using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Posts
    {
        [Key]
        public long Id_Post { get; set; }
        public string Post { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Post { get; set; }
        
    }
}
