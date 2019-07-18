using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProfessionalNetwork.Models
{
    public class LikesVM
    {
        [Key]
        public long Id_Like { get; set; }

        public long FK_jobseeker { get; set; }
        public Jobseeker Jobseeker { get; set; }

        public long FK_Post { get; set; }
        public Posts Posts { get; set; }
    }
}