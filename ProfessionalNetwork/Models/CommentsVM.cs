using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProfessionalNetwork.Models
{
    public class CommentsVM
    {
        [Key]
        public int Id_Com { get; set; }

        public long FK_jobseeker { get; set; }
        public JobseekerVM Jobseeker { get; set; }

        public long FK_Post { get; set; }
        public PostsVM Posts { get; set; }

        public string Comment { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date_Com { get; set; }
    }
}