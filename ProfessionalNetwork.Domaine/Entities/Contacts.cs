using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Domaine.Entities
{
    public class Contacts
    {   
        [Key]
        public long Id_Contact { get; set; }
        public string First_Name_Contact { get; set; }
        public string Last_Name_Contact { get; set; }
        [DataType(DataType.ImageUrl), Required(ErrorMessage = "la proprieté image est obligatoire")]
        public string Photo_Contacts { get; set; }
    }
}
