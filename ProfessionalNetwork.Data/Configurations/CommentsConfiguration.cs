﻿using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    class CommentsConfiguration : EntityTypeConfiguration<Comments>
    {
        public CommentsConfiguration()
        {
            this.ToTable("Comments");
            HasKey(a => new { a.Id_Com });

            HasRequired<Jobseeker>(t => t.Jobseeker).WithMany(t => t.Comments).
                  HasForeignKey(t => t.FK_jobseeker).WillCascadeOnDelete(false);
            HasRequired<Posts>(t => t.Posts).WithMany(t => t.Comments).
                  HasForeignKey(t => t.FK_Post).WillCascadeOnDelete(false);
        }
    }
}
