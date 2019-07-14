using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Models

{
    public class AccountVM : EntityTrace
    {
        //[Key]
       // public long Id_Account { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
        public Boolean Enable { get; set; }
        [DataType(DataType.ImageUrl), Required(ErrorMessage = "la proprieté image est obligatoire")] 
        public string Photo { get; set; }
    }
}
