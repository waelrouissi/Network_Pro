using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProfessionalNetwork.Models
{
    public class PostsVM
    {

        [Key]
        public long Id_Post { get; set; }
        public string Post { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date_Post { get; set; }

        public long Job_SeekerFK { get; set; }
        public JobseekerVM Jobseeker { get; set; }

        public Boolean isLiked { get; set; }
        public Boolean isPostOwner { get; set; }
        public int nbrLikes { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Likes> Likes { get; set; }

    }
}