using ProfessionalNetwork.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalNetwork.Data.Configurations
{
    public class TestConfiguration: EntityTypeConfiguration<Test>
    {
        public  TestConfiguration()
        {
            this.ToTable("Test");
            HasKey<long>(a => a.Id_Test);

            
        }
    }
}
