using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Administrator: Account
    {
        [Key]
        public long Id_Administrator { get; set; }

    }
}
